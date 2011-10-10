using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class LaboratuvarKabulForm : MDIChildForm
    {
        public LaboratuvarKabulForm()
        {
            InitializeComponent();
        }

        private void LaboratuvarKabulForm_Load(object sender, EventArgs e)
        {
                LoadLookUps();
        }

        private void LoadLookUps()
        {
            //UIUtilities.BindLookUpEdit(this.luePaymentType, LookUpServices.PaymentTypes);
            //this.luePaymentType.EditValue = PaymentType.DefaultValue;

            //UIUtilities.BindLookUpEdit(this.lueVAT, LookUpServices.VATs);
            //this.lueVAT.EditValue = VAT.DefaultValue;
            
            //UIUtilities.BindLookUpEdit(this.luePOS, LookUpServices.POSs);
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}