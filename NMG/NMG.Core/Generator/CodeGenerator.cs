﻿using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using NMG.Core.Domain;
using NMG.Core.TextFormatter;

namespace NMG.Core.Generator
{
    public class CodeGenerator : AbstractGenerator
    {
        private readonly ApplicationPreferences applicationPreferences;
        private readonly Language language;

        public CodeGenerator(ApplicationPreferences applicationPreferences, Table table) : base( applicationPreferences.FolderPath, applicationPreferences.TableName, applicationPreferences.NameSpace, applicationPreferences.AssemblyName, applicationPreferences.Sequence, table, applicationPreferences)
        {
            this.applicationPreferences = applicationPreferences;
            language = applicationPreferences.Language;
        }

        public override void Generate()
        {
            var compileUnit = GetCompileUnit();
            WriteToFile(compileUnit, Formatter.FormatSingular(tableName));
        }

        public CodeCompileUnit GetCompileUnit()
        {
            var codeGenerationHelper = new CodeGenerationHelper();
            var compileUnit = codeGenerationHelper.GetCodeCompileUnit(nameSpace, Formatter.FormatSingular(Table.Name));

            var mapper = new DataTypeMapper();
            var newType = compileUnit.Namespaces[0].Types[0];
            
            newType.IsPartial = applicationPreferences.GeneratePartialClasses;

            foreach (var pk in Table.PrimaryKey.Columns)
            {
                var mapFromDbType = mapper.MapFromDBType(pk.DataType, null, null, null);
                newType.Members.Add(codeGenerationHelper.CreateAutoProperty(mapFromDbType.ToString(), Formatter.FormatText(pk.Name)));
            }

            // Note that a foreign key referencing a primary within the same table will end up giving you a foreign key property with the same name as the table.
            foreach (var fk in Table.ForeignKeys.Where(fk => !string.IsNullOrEmpty(fk.References)))
            {
                newType.Members.Add(codeGenerationHelper.CreateAutoProperty(Formatter.FormatSingular(fk.References), Formatter.FormatSingular(fk.References)));
            }

            foreach (var hasMany in Table.HasManyRelationships)
            {
                newType.Members.Add(codeGenerationHelper.CreateAutoProperty("IList<" + Formatter.FormatSingular(hasMany.Reference) + ">",Formatter.FormatPlural(hasMany.Reference)));
            }

            foreach (var column in Table.Columns.Where(x => x.IsPrimaryKey != true && x.IsForeignKey != true))
            {
                var mapFromDbType = mapper.MapFromDBType(column.DataType, null, null, null);
                newType.Members.Add(codeGenerationHelper.CreateAutoProperty(mapFromDbType, Formatter.FormatText(column.Name), column.IsNullable));
            }
            
            var constructor = new CodeConstructor {Attributes = MemberAttributes.Public};
            newType.Members.Add(constructor);
            return compileUnit;
        }

        private void WriteToFile(CodeCompileUnit compileUnit, string className)
        {
            var provider = GetCodeDomProvider();
            var sourceFile = GetCompleteFilePath(provider, className.MakeSingular());
            using (provider)
            {
                var streamWriter = new StreamWriter(sourceFile);
                var textWriter = new IndentedTextWriter(streamWriter, "    ");
                using (textWriter)
                {
                    using (streamWriter)
                    {
                        var options = new CodeGeneratorOptions {BlankLinesBetweenMembers = false};
                        provider.GenerateCodeFromCompileUnit(compileUnit, textWriter, options);
                    }
                }
            }
            CleanupGeneratedFile(sourceFile);
        }

        private static void CleanupGeneratedFile(string sourceFile)
        {
            string entireContent;
            using (var reader = new StreamReader(sourceFile))
            {
                entireContent = reader.ReadToEnd();
            }
            entireContent = RemoveComments(entireContent);
            entireContent = AddStandardHeader(entireContent);
            entireContent = FixAutoProperties(entireContent);
            using (var writer = new StreamWriter(sourceFile))
            {
                writer.Write(entireContent);
            }
        }

        // Hack : Auto property generator is not there in CodeDom.
        private static string FixAutoProperties(string entireContent)
        {
            // Do NOT mess with this...
            entireContent = entireContent.Replace(@"{
        }", "{ }");
            entireContent = entireContent.Replace(
                @"{
            get {
            }
            set {
            }
        }", "{ get; set; }");
            return entireContent;
        }

        private static string AddStandardHeader(string entireContent)
        {
            entireContent = "using System; \n" + entireContent;
            entireContent = "using System.Text; \n" + entireContent;
            entireContent = "using System.Collections.Generic; \n" + entireContent;
            return entireContent;
        }

        private static string RemoveComments(string entireContent)
        {
            int end = entireContent.LastIndexOf("----------");
            entireContent = entireContent.Remove(0, end + 10);
            return entireContent;
        }

        private string GetCompleteFilePath(CodeDomProvider provider, string className)
        {
            string fileName = filePath + className;
            return provider.FileExtension[0] == '.'
                       ? fileName + provider.FileExtension
                       : fileName + "." + provider.FileExtension;
        }

        private CodeDomProvider GetCodeDomProvider()
        {
            return language == Language.CSharp ? (CodeDomProvider) new CSharpCodeProvider() : new VBCodeProvider();
        }
    }
}