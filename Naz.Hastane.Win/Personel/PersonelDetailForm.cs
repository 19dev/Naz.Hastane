using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelDetailForm<T> : MDIChildForm where T : PersonelDetail, new()
    {
        public bool IsOK { get; set; }
        protected Personel _Personel;

        private T _T = default(T);

        public T TheObject
        {
            get { return _T; }
            set
            {
                if (_T == default(T) || !_T.Equals(value))
                {
                    _T = value;
                    InitBindings();
                }
            }
        }

        public PersonelDetailForm()
        {
            InitializeComponent();
        }

        public virtual void PersonelDetailFormParams(Personel personel, int detailID)
        {
            IsOK = false;
            if (personel == null)
                Close();

            _Personel = personel;

            T t = LookUpServices.GetByID<T>(Session, detailID);
            if (t == null)
                t = CreateNewObject();

            TheObject = t;
        }

        protected virtual void InitBindings(){}

        protected virtual void LoadLookUps(){}

        protected virtual bool Save(){return false;}

        private T CreateNewObject()
        {
            T t = DataBindingFactory.Create<T>();
            t.Personel = _Personel;
            return t;
        }

        protected void sbCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        protected void sbSaveAndClose_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                IsOK = true;
                Close();
            }
        }

        protected void sbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                IsOK = true;
                TheObject = CreateNewObject();
            }
        }

    }

    public class PersonelDetailEgitimForm: PersonelDetailForm<PersonelEgitim>{}
    public class PersonelDetailHastaneBolumuForm : PersonelDetailForm<PersonelHastaneBolumu> { }
    public class PersonelDetailIzinForm : PersonelDetailForm<PersonelIzin> { }
    public class PersonelDetailRaporForm : PersonelDetailForm<PersonelRapor> { }
    public class PersonelDetailSertifikaForm : PersonelDetailForm<PersonelSertifika> { }
    public class PersonelDetailYabanciDilForm : PersonelDetailForm<PersonelYabanciDil> { }
}