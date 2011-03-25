using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;

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
    }
}
