using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.Medula;
using Naz.Hastane.Win.Controls;
using Naz.Hastane.Reports;
using Naz.Utilities.Classes;
using System.Collections.Generic;
using Naz.Mernis.Service;
using DevExpress.XtraGrid.Views.Grid;
using Naz.Hastane.Reports.Classes;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using System.Drawing;
using NHibernate;
using Naz.Hastane.Data.DTO;
using Naz.Hastane.Win.Utilities;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelForm : MDIChildForm
    {
        private Personel _Personnel = null;

        public Personel Personnel
        {
            get { return _Personnel; }
            set
            {
                if (_Personnel != value) 
                {
                    _Personnel = value;
                    //LoadSubLists();
                }
            }
        }

        //private void LoadSubLists()
        //{
            
        //}
                
        private PersonelForm()
        {
            InitializeComponent();
        }

        //public PersonelForm() : this()
        //{
        //    Personnel = PersonnelServices.GetNewPersonnel();
        //    //if (Personnel == null)
        //    //{
        //    //    Personnel = PersonnelServices.GetNewPersonnel();
        //    //    return;
        //    //}
        //    //else
        //    //{
        //    //    Personnel = result[0];
        //    //}
        //    InitBindings();
        //}

        public PersonelForm(int ID) : this()
        {
            Personnel = PersonnelServices.GetPersonnelByID(ID);
            if (Personnel == null)
            {
                Personnel = PersonnelServices.GetNewPersonnel();
                InitBindings();
                return;
            }
            //else
            //{
            //    Personnel = result[0];
            //}
            InitBindings();            
        }

        //public static Personel GetPersonnelByID(string aPersonnelNo, ISession session)
        //{
        //    if (String.IsNullOrWhiteSpace(aPersonnelNo))
        //        return null;

        //    return session.Get<Personel>(aPersonnelNo);
        //}
        
        private void InitBindings()
        {
            LoadLookUps();
            
            UIUtilities.BindControl(tePersonnelNo, Personnel, x => x.PersonelNo);
            UIUtilities.BindControl(teTCID, Personnel, x => x.TCID);
            UIUtilities.BindControl(teFirstName, Personnel, x => x.Ad);
            UIUtilities.BindControl(teSurname, Personnel, x => x.Soyad);
            UIUtilities.BindControl(rgSex, Personnel, x => x.Cinsiyeti);
            UIUtilities.BindControl(teHomePhone1, Personnel, x => x.EvTelefonu);
            UIUtilities.BindControl(teMobilePhone, Personnel, x => x.CepTelefonu);
            UIUtilities.BindControl(teEmail, Personnel, x => x.Email);
            UIUtilities.BindControl(deEntryDate, Personnel, x => x.IseGirisTarihi);
            UIUtilities.BindControl(deExitDate, Personnel, x => x.AyrilisTarihi);
            UIUtilities.BindControl(teHomeAddress, Personnel, x => x.EvAdresi);
            UIUtilities.BindControl(teHomeDistrict, Personnel, x => x.Mahalle);
            UIUtilities.BindControl(teHomeTown, Personnel, x => x.Ilce);
            UIUtilities.BindControl(lueHomeCity, Personnel, x => x.Il);
            UIUtilities.BindControl(lueBloodType, Personnel, x => x.KanGrubu);

        }

        private void LoadLookUps()
        {            
            UIUtilities.BindLookUpEdit(this.lueHomeCity, LookUpServices.Cities, displayMember: "Value", valueMember: "Value");
            UIUtilities.BindLookUpEdit(this.lueBloodType, LookUpServices.BloodTypes); //, displayMember: "Value", valueMember: "Value"); 
        }

        private void sbSavePersonnel_Click(object sender, EventArgs e)
        {
            SavePersonnel();
        }

        private void SavePersonnel()
        {
            if (String.IsNullOrWhiteSpace(Personnel.Ad))
            {
                XtraMessageBox.Show("Lütfen Personelin Adını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(Personnel.Soyad))
            {
                XtraMessageBox.Show("Lütfen Personelin Soyadını Kontrol Ediniz", "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                if (String.IsNullOrWhiteSpace(Personnel.PersonelNo))
                {
                    PersonnelServices.SavePersonnel(Session, Personnel);
                    OpenNewForm();
                }
                else
                {
                    PersonnelServices.SavePersonnel(Session, Personnel);
                    XtraMessageBox.Show("Personel Kayıt Edilmiştir", "Personel Kayıt Onayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                XtraMessageBox.Show("Personel Kayıt Edilemedi:" + error.Message, "Personel Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenNewForm()
        {
            //(this.MdiParent as frmMain).OpenPersonnel(Personnel.PersonelNo);
            this.Close();
        }      

        private void sbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }                  

        private void PersonelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                CloseForm();
            else if (e.KeyCode == Keys.F5)
                SavePersonnel();
        }

        public void SetNewTCID(string TCID)
        {
            this.teTCID.Text = TCID;
        }
    }
}