using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class DetailEditForm<T> : MDIChildForm where T: IDBase, new()
    {
        public bool IsOK { get; set; }

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

        public DetailEditForm()
        {
            InitializeComponent();
        }

        public virtual void DetailFormParams(int detailID)
        {
            IsOK = false;

            T t = LookUpServices.GetByID<T>(Session, detailID);
            if (t == null)
                t = CreateNewObject();

            TheObject = t;
        }

        protected virtual void InitBindings(){}

        protected virtual void LoadLookUps(){}

        protected virtual bool Save(){return false;}

        protected virtual T CreateNewObject()
        {
            T t = DataBindingFactory.Create<T>();
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
}