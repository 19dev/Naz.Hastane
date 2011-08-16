
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
            ReLoad();
        }

        private void ReLoad()
        {
            gcHizmetIciEgitim.DataSource = LookUpServices.GetAll<HizmetIciEgitim>(Session);
            ShowPersonels();
        }

        private void sbAddHizmetIciEgitim_Click(object sender, System.EventArgs e)
        {
            Add<HizmetIciEgitimEditForm, HizmetIciEgitim>();
        }

        private void sbChangeHizmetIciEgitim_Click(object sender, System.EventArgs e)
        {
            Change<HizmetIciEgitimEditForm, HizmetIciEgitim>(gvHizmetIciEgitim);
        }

        private void sbDeleteHizmetIciEgitim_Click(object sender, System.EventArgs e)
        {
            Delete<HizmetIciEgitim>(gvHizmetIciEgitim, "Hizmetiçi Eğitim Kaydı Silinmiştir.",
                "Hizmetiçi Eğitim Kaydı Silinemedi:", "Hizmetiçi Eğitim Kaydı Silme İşlemi");
        }

        #region DetailTemplates
        private void Add<TForm, T>()
            where TForm : DetailEditForm<T>, new()
            where T : IDBase, new()
        {
            using (TForm frm = new TForm())
            {
                frm.DetailFormParams( 0);
                frm.ShowDialog();
                if (frm.IsOK)
                    ReLoad();
            }
        }

        private void Change<TForm, T>(GridView gv)
            where TForm : DetailEditForm<T>, new()
            where T : IDBase, new()
        {
            T o = gv.GetFocusedRow() as T;
            if (o != null)
                using (TForm frm = new TForm())
                {
                    frm.DetailFormParams(o.ID);
                    frm.ShowDialog();
                    if (frm.IsOK)
                        ReLoad();
                }
        }

        private void Delete<TObject>(GridView gv, string deleteSuccesful, string deleteFail, string msgCaption) where TObject : IDBase
        {
            TObject o = gv.GetFocusedRow() as TObject;
            if (o != null)
            {
                try
                {
                    LookUpServices.Delete(Session, o);
                    ReLoad();
                    XtraMessageBox.Show(deleteSuccesful, msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    XtraMessageBox.Show(deleteFail + error.Message, msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void gvHizmetIciEgitim_DoubleClick(object sender, EventArgs e)
        {
            Change<HizmetIciEgitimEditForm, HizmetIciEgitim>(gvHizmetIciEgitim);
        }

        private void gvPersonel_DoubleClick(object sender, EventArgs e)
        {
            Change<HizmetIciEgitimPersonelEditForm, PersonelHizmetIciEgitim>(gvPersonel);
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

        private void sbAddPersonel_Click(object sender, EventArgs e)
        {
            Add<HizmetIciEgitimPersonelEditForm, PersonelHizmetIciEgitim>();
        }

        private void sbChangePersonel_Click(object sender, EventArgs e)
        {
            Change<HizmetIciEgitimPersonelEditForm, PersonelHizmetIciEgitim>(gvPersonel);
        }

        private void sbDeletePersonel_Click(object sender, EventArgs e)
        {
            Delete<PersonelHizmetIciEgitim>(gvPersonel, "Hizmetiçi Eğitim Personel Kaydı Silinmiştir.",
                "Hizmetiçi Eğitim Personel Kaydı Silinemedi:", "Hizmetiçi Eğitim Personel Kaydı Silme İşlemi");
        }

        
    }
}