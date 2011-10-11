
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System;
namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class HizmetIciEgitimForm : MDIChildForm
    {
        private HizmetIciEgitim CurrentHizmetIciEgitim = null;

        public HizmetIciEgitimForm()
        {
            InitializeComponent();
            ReLoadForm();
        }

        protected override void ReLoadForm()
        {
            gcHizmetIciEgitim.DataSource = LookUpServices.GetAll<HizmetIciEgitim>(Session);
            ShowPersonels();
        }

        #region HizmetIciEgitim
        private void sbAddHizmetIciEgitim_Click(object sender, System.EventArgs e)
        {
            AddDetail<HizmetIciEgitimEditForm, HizmetIciEgitim>();
        }

        private void sbChangeHizmetIciEgitim_Click(object sender, System.EventArgs e)
        {
            EditDetail<HizmetIciEgitimEditForm, HizmetIciEgitim>(gvHizmetIciEgitim);
        }

        private void sbDeleteHizmetIciEgitim_Click(object sender, System.EventArgs e)
        {
            DeleteDetail<HizmetIciEgitim>(gvHizmetIciEgitim, "Hizmetiçi Eğitim Kaydı Silmek İstiyor Musunuz?", "Hizmetiçi Eğitim Kaydı Silinmiştir.",
                "Hizmetiçi Eğitim Kaydı Silinemedi:", "Hizmetiçi Eğitim Kaydı Silme İşlemi");
        }
        #endregion

        private void gvHizmetIciEgitim_DoubleClick(object sender, EventArgs e)
        {
            EditDetail<HizmetIciEgitimEditForm, HizmetIciEgitim>(gvHizmetIciEgitim);
        }

        private void gvPersonel_DoubleClick(object sender, EventArgs e)
        {
            ChangePersonel();
        }

        private void gvHizmetIciEgitim_Click(object sender, EventArgs e)
        {
            ShowPersonels();
        }

        private void ShowPersonels()
        {
            CurrentHizmetIciEgitim = gvHizmetIciEgitim.GetFocusedRow() as HizmetIciEgitim;

            if (CurrentHizmetIciEgitim != null)
                gcPersonel.DataSource = CurrentHizmetIciEgitim.PersonelHizmetIciEgitims;

        }

        private void AddPersonel()
        {
            if (CurrentHizmetIciEgitim != null)
                using (HizmetIciEgitimPersonelEditForm frm = new HizmetIciEgitimPersonelEditForm())
                {
                    frm.DetailFormParams(CurrentHizmetIciEgitim, 0);
                    frm.ShowDialog();
                    if (frm.IsOK)
                        ReLoadForm();
                }
        }
        private void sbAddPersonel_Click(object sender, EventArgs e)
        {
            AddPersonel();
        }

        private void ChangePersonel()
        {
            if (CurrentHizmetIciEgitim != null)
            {
                PersonelHizmetIciEgitim o = gvPersonel.GetFocusedRow() as PersonelHizmetIciEgitim;
                if (o != null)
                    using (HizmetIciEgitimPersonelEditForm frm = new HizmetIciEgitimPersonelEditForm())
                    {
                        frm.DetailFormParams(CurrentHizmetIciEgitim, o.ID);
                        frm.ShowDialog();
                        if (frm.IsOK)
                            ReLoadForm();
                    }
            }
        }
        private void sbChangePersonel_Click(object sender, EventArgs e)
        {
            ChangePersonel();
        }

        private void sbDeletePersonel_Click(object sender, EventArgs e)
        {
            DeleteDetail<PersonelHizmetIciEgitim>(gvPersonel, "Hizmetiçi Eğitim Personel Kaydı Silmek İstiyor Musunuz?", "Hizmetiçi Eğitim Personel Kaydı Silinmiştir.",
                "Hizmetiçi Eğitim Personel Kaydı Silinemedi:", "Hizmetiçi Eğitim Personel Kaydı Silme İşlemi");
        }
        
    }
}