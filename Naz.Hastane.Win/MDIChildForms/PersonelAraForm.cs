using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;
using DevExpress.Data.Filtering;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System.Linq.Expressions;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelAraForm : MDIChildForm
    {
        public PersonelAraForm()
        {
            InitializeComponent();
        }

        private void bntSelect_Click(object sender, EventArgs e)
        {
            OpenDetail();
        }

        private void OpenDetail()
        {
            if (gridView1.GetFocusedRow() != null)
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    string personnelID;
                    personnelID = gridView1.GetFocusedRowCellDisplayText("ID");
                    (this.MdiParent as frmMain).OpenPersonnel(Convert.ToInt32(personnelID));
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonelAra();
        }

        private void PersonelAra()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (SearchByTCID()) return;
                if (SearchByPersonnelNo()) return;

                string criteriaString = "";

                //GetCriteria(this.teTCId, ref criteriaString, "TCID");
                //GetCriteria(this.tePersonnelNo, ref criteriaString, "PersonelNo");
                GetCriteria(this.teFirstName, ref criteriaString, "Ad");
                GetCriteria(this.teLastName, ref criteriaString, "Soyad");

                if (criteriaString.Length > 0)
                {
                    IList<Personel> personnels = PersonnelServices.GetByWhere(criteriaString);
                    //this.lcHastaAdeti.Text = "Bulunan:" + patients.Count.ToString();
                    this.gridPersonelArama.DataSource = personnels;
                    if (personnels.Count == 1)
                    {
                        (this.MdiParent as frmMain).OpenPersonnel(personnels[0].ID);
                    }
                    else if (personnels.Count == 0)
                    {
                        if (XtraMessageBox.Show("Bu Kriterlerle Bir Personel Kayıtlı Değil, Yeni Personel Kayıtı Yaratmak İster Misiniz?", "Personel Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            (this.MdiParent as frmMain).OpenNewPersonnel();
                        }
                    }
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private bool SearchByTCID()
        {
            string TCID = this.teTCId.Text;
            if (PersonnelServices.IsValidTCID(TCID))
            {
                IList<Personel> result = PersonnelServices.GetByTCId(TCID);
                if (result.Count == 0)
                {
                    if (XtraMessageBox.Show("Bu TC Kimlik Numaralı Personel Kayıtlı Değil, Yeni Personel Kayıtı Yaratmak İster Misiniz?", "Personel Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        (this.MdiParent as frmMain).OpenNewPersonnelWithTCID(TCID);
                        return true;
                    }
                }
                else if (result.Count == 1)
                {
                    (this.MdiParent as frmMain).OpenPersonnel(result[0].ID);
                    return true;
                }
            }
            return false;
        }

        private bool SearchByPersonnelNo()
        {
            string personnelNo = this.tePersonnelNo.Text.Trim();
            if (PersonnelServices.IsValidNumeric(personnelNo))
            {
                IList<Personel> result = PersonnelServices.GetPersonnelByPersonnelNo(personnelNo);
                if (result.Count == 0)
                {
                    if (XtraMessageBox.Show("Bu Personel Numaralı Bir Personel Kayıtlı Değil, Yeni Personel Kayıtı Yaratmak İster Misiniz?", "Personel Kayıtı Arama", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        (this.MdiParent as frmMain).OpenNewPersonnel();
                    }
                }
                else if(result.Count == 1)
                {
                    (this.MdiParent as frmMain).OpenPersonnel(result[0].ID);
                }
                return true;
            }
            return false;
        }

        private void AddCriteria(ref string aCriteria1, string aCriteria2)
        {
            if (aCriteria1.Length > 0)
            {
                aCriteria1 = aCriteria1 + " AND " + aCriteria2;
            }
            else
            {
                aCriteria1 = aCriteria2;
            }
        }

        private void GetCriteria(Control c, ref string aCriteria, string aFieldName)
        {
            if (c.Text.Length > 0) AddCriteria(ref aCriteria, "personel." + aFieldName + " Like '%" + c.Text + "%'");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.teTCId.Text = "";
            this.tePersonnelNo.Text = "";
            this.teFirstName.Text = "";
            this.teLastName.Text = "";

            //this.gridHastaArama.DataSource = new List<Patient>();

            this.AcceptButton = this.sbSearch;
        }

        //private void gridHastaArama_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    OpenDetail();
        //}

        private void sbNew_Click(object sender, EventArgs e)
        {
            (this.MdiParent as frmMain).OpenNewPersonnel();
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridPersonelArama_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenDetail();
        }

        //private void SGKFindPatientForm_Shown(object sender, EventArgs e)
        //{
        //    this.teTCId.Focus();
        //}
    }
}