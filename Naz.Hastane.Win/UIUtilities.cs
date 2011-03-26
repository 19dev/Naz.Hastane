using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;

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
            lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", 10, "Kod"));
            lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", 30, typeof(T).GetDescription()));
            lue.Properties.DisplayMember = "Value";
            lue.Properties.ValueMember = "Code";
            lue.Properties.DataSource = dataSourceList;
        }
    }
}
