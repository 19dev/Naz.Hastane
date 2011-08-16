using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PersonelDetailEditForm<T> : DetailEditForm<T> where T :PersonelDetail, new()
    {
        protected Personel _Personel;

        public PersonelDetailEditForm()
        {
            InitializeComponent();
        }

        public virtual void DetailFormParams(Personel personel, int detailID)
        {
            if (personel == null)
                Close();

            _Personel = personel;

            base.DetailFormParams(detailID);

        }

        protected override T CreateNewObject()
        {
            T t = base.CreateNewObject();
            t.Personel = _Personel;
            return t;
        }

    }

}