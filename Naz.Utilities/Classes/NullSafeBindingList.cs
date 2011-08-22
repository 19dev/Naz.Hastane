using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace Naz.Classes
{
    public class NullSafeBindingList<T> : BindingList<T> where T : new() 
    {
          public NullSafeBindingList(IList<T> list, string keyPropertyName, string displayPropertyName) : base(list) 
          {
            Type t = typeof(T);
            PropertyInfo idProp = t.GetProperty(keyPropertyName);
            PropertyInfo dispProp = t.GetProperty(displayPropertyName);
            foreach (T ts in list)
            {
                if ((int)idProp.GetValue(ts, null) == 0)
                    return;
            }
            T nullObj = new T();
            idProp.SetValue(nullObj, 0, null);
            dispProp.SetValue(nullObj, "", null);
            this.Items.Insert(0,nullObj);
        }
    }
}
