using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Utilities.Classes;

namespace Naz.Hastane.Win
{
    public static class UIUtilities
    {
        public static User CurrentUser = null;

        //public static void BindLookUpEdit(LookUpEdit lue, Object dataSourceList,
        //    string displayMember = "Value", string valueMember = "ID")
        //{
        //    lue.Properties.DisplayMember = displayMember;
        //    lue.Properties.ValueMember = valueMember;
        //    lue.Properties.DataSource = dataSourceList;
        //}
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

            foreach (var md in ReflectionUtilities.MemberDescriptions<T>())
            {
                lue.Properties.Columns.Add(new LookUpColumnInfo(md.Key, md.Value));
            }
            lue.Properties.DataSource = dataSourceList;
        }

        public static void BindGrid<T>(GridView view, IList<T> dataSourceList) where T : new()
        {
            view.Columns.Clear();

            foreach (var md in ReflectionUtilities.MemberDescriptions<T>())
            {
                GridColumn column = view.Columns.AddField(md.Key);
                column.Caption = md.Value;
                column.Visible = true;
            }
            view.GridControl.DataSource = dataSourceList;
        }

    }
}
