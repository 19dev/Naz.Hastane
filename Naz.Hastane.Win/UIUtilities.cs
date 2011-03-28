using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Data.Services;
using System.Collections;

namespace Naz.Hastane.Win
{
    public static class UIUtilities
    {
        public static void BindLookUpEdit(LookUpEdit lue, Object dataSourceList,
            string displayMember = "Value", string valueMember = "ID")
        {
            lue.Properties.DisplayMember = displayMember;
            lue.Properties.ValueMember = valueMember;
            lue.Properties.DataSource = dataSourceList;
        }
        public static void BindLookUpEdit<T>(LookUpEdit lue, IList<T> dataSourceList) where T : new()
        {
            lue.Properties.Columns.Clear();
            lue.Properties.DisplayMember = "Value";
            lue.Properties.ValueMember = "Code";
            lue.Properties.Columns.Add(new LookUpColumnInfo("Code", 10, "Kod"));
            lue.Properties.Columns.Add(new LookUpColumnInfo("Value", 30, typeof(T).GetDescription()));
            lue.Properties.DataSource = dataSourceList;
        }
        
        public static void BindLookUpEditAllColumns<T>(LookUpEdit lue, IList<T> dataSourceList) where T : new()
        {
            lue.Properties.Columns.Clear();
            lue.Properties.DisplayMember = "Value";
            lue.Properties.ValueMember = "Code";

            foreach (var md in MemberDescriptions<T>())
            {
                lue.Properties.Columns.Add(new LookUpColumnInfo(md.Key, md.Value));
            }
            lue.Properties.DataSource = dataSourceList;
        }

        public static void BindGrid<T>(GridView view, IList<T> dataSourceList) where T : new()
        {
            view.Columns.Clear();

            foreach (var md in MemberDescriptions<T>())
            {
                GridColumn column = view.Columns.AddField(md.Key);
                column.Caption = md.Value;
                column.Visible = true;
            }
            view.GridControl.DataSource = dataSourceList;
        }

        public static IEnumerable<KeyValuePair<string,string>> MemberDescriptions<T>() where T : new()
        {
            foreach (var member in typeof(T).GetMembers())
            {
                var attributes = member.GetCustomAttributes(true);
                foreach (Attribute a in attributes)
                {
                    DescriptionAttribute da = a as DescriptionAttribute;
                    if (da != null && da.Description.Length > 0)
                    {
                        yield return new KeyValuePair<string,string>(member.Name, da.Description);
                    }
                }
            }

        }
    }
}
