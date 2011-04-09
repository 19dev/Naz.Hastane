using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace Naz.Utilities.Classes
{
    public static class ReflectionUtilities
    {
        public static string GetDescription(this object enumerationValue)
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }

        public static string GetDescription(this Type t)
        {
            object[] attrs = t.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attrs != null && attrs.Length > 0)
            {
                return ((DescriptionAttribute)attrs[0]).Description;
            }
            return t.ToString();
        }

        public static IEnumerable<KeyValuePair<string, string>> MemberDescriptions<T>() where T : new()
        {
            foreach (var member in typeof(T).GetMembers())
            {
                var attributes = member.GetCustomAttributes(true);
                foreach (Attribute a in attributes)
                {
                    DescriptionAttribute da = a as DescriptionAttribute;
                    if (da != null && da.Description.Length > 0)
                    {
                        yield return new KeyValuePair<string, string>(member.Name, da.Description);
                    }
                }
            }
        }

        public static string GetMemberValueByName(Object myObject, string memberName)
        {
            Type t = myObject.GetType();
            PropertyInfo p = t.GetProperty(memberName);
            string s = p.GetValue(myObject, null).ToString();
            return s;
        }
    }
}
