using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using System.Reflection;
using DevExpress.XtraGrid.Columns;
using Naz.Hastane.Data.Entities.LookUp.Special;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class LookUpForm<T> : MDIChildForm where T : new()
    {
        public LookUpForm()
        {
            InitializeComponent();
        }
        public LookUpForm(IList<T> lookUpTable)
        {
            InitializeComponent();

            if (typeof(T) == typeof(Doctor))
                LookUpFormDoctor(lookUpTable);
            else
                UIUtilities.BindGrid(this.gvLookUp, lookUpTable);
        }
        public void LookUpFormDoctor(object lookUpTable)
        {
            GridColumn column;
            column = this.gvLookUp.Columns.AddField("ID");
            column.Caption = "Doktor Kodu";
            column.Visible = true;
            column = this.gvLookUp.Columns.AddField("Value");
            column.Caption = "Doktor Adı";
            column.Visible = true;
            column = this.gvLookUp.Columns.AddField("QueueNo");
            column.Caption = "Sıra No";
            column.Visible = true;
            column = this.gvLookUp.Columns.AddField("LicenseNo");
            column.Caption = "Lisans No";
            column.Visible = true;
            //column = this.gvLookUp.Columns.AddField("Service.Value");
            //column.Caption = "Servis";
            //column.Visible = true;
            this.gvLookUp.GridControl.DataSource = lookUpTable;
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}