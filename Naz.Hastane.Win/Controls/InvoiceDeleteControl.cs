using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NHibernate;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.Accounting;
using Naz.Hastane.Win.Forms;

namespace Naz.Hastane.Win.Controls
{
    public partial class InvoiceDeleteControl : DevExpress.XtraEditors.XtraUserControl
    {
        private ISession _Session;
        private Patient _Patient;
        private IList<AdvancePaymentUsed> _AdvancePaymentUseds;
        private Invoice currentInvoice;

        public InvoiceDeleteControl()
        {
            InitializeComponent();
        }

          public void QueryInvoices(ISession session, Patient patient)
        {
            _Session = session;
            _Patient = patient;
            QueryInvoices();
        }

          private void QueryInvoices()
          {

            try
            {
                gvInvoices.BeginDataUpdate();
                
                this.gcInvoices.DataSource = PatientServices.GetPatientInvoices(_Session, _Patient);
                try
                {
                    gvInvoices.ClearSorting();
                    gvInvoices.Columns["FATURATARIHI"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                }
                finally
                {
                    gvInvoices.EndDataUpdate();
                }
                QueryProducts();
            }
            catch (Exception ex)
            {
                SimpleMsgBoxForm.ShowMsgBox("Kayıtlar Okunamadı:" + ex.Message, "Fatura Kayıtları Okuma Uyarısı", true);
            }

        }

        private void gvInvoices_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            QueryProducts();
        }

        private void QueryProducts()
        {
            currentInvoice = (Invoice)gvInvoices.GetFocusedRow();
            sbCancelInvoice.Enabled = (currentInvoice.ISIPTAL != "1");

            if (currentInvoice != null)
            {
                gcProducts.DataSource = PatientServices.GetProductsForInvoice(_Session, currentInvoice);
                    
                _AdvancePaymentUseds = PatientServices.GetAdvancePaymentsForInvoice(_Session, currentInvoice);
                gcAdvancePayments.DataSource = _AdvancePaymentUseds;
            }
        }

        private void sbCancelInvoice_Click(object sender, EventArgs e)
        {
            CancelInvoice();
        }

        private void CancelInvoice()
        {
            if (currentInvoice == null)
                return;

            if (SimpleMsgBoxForm.ShowYesNo(String.Format("{0} Nolu Faturanın İptal Edilmesini İstiyor musunuz?", currentInvoice.FATURANO), "Fatura İptal Uyarısı", true) != DialogResult.Yes)
                return;

            try
            {
                PatientServices.DeleteInvoice(_Session, UIUtilities.CurrentUser, currentInvoice, _AdvancePaymentUseds);
                if (SimpleMsgBoxForm.ShowYesNo("Faturaya Ait Avans Kaydının İade Edilmesini İstiyor musunuz?", "Avas İade Uyarısı", true) == DialogResult.Yes)
                {
                    foreach (AdvancePaymentUsed apu in _AdvancePaymentUseds)
                    {
                        try
                        {
                            PatientServices.RebateAdvancePayment(_Session, UIUtilities.CurrentUser, apu.AdvancePayment);
                        }
                        catch (Exception ex)
                        {
                            SimpleMsgBoxForm.ShowMsgBox(String.Format("{0} Numaralı Avans İadesi Yapılamadı:", apu.AdvancePayment.AV_ID) + ex.Message, "Fatura İptal Uyarısı", true);
                        }
                    }
                }
                QueryInvoices();
            }
            catch (Exception ex)
            {
                SimpleMsgBoxForm.ShowMsgBox("Fatura İptal Edilemedi:" + ex.Message, "Fatura İptal Uyarısı", true);
            }
        }

        private void sbRefresh_Click(object sender, EventArgs e)
        {
            QueryInvoices();
        }
    }


    //select K.TARIH, K.MAKBUZNO, K.TUTAR, K.USER_ID, K.FATURANO, F.FATURANO AS FATNO, K.MAKNO, K.SNR from KASA K LEFT OUTER JOIN FATURA F ON (K.FATURANO = F.FATURA_ID) where K.KNR = '870366' and K.ISIPTAL is NULL and K.MAKBUZTIPI='V' order by K.TARIH DESC

    //OK
    //SELECT FATURATARIHI, FATURA_ID, FATURANO, HIZMETTUTARI, INDIRIM, KDVTUTARI, YUVARLAMA, FATURATUTARI, MAKNO, USER_ID, ISIPTAL,AMAKNO,IPTAL_NEDENI FROM FATURA where KNR='870366' and FATURATIPI = 'H' 

    //SELECT F.FATURATARIHI, F.FATURA_ID, F.FATURANO, F.HIZMETTUTARI, F.INDIRIM, F.KDVTUTARI, F.YUVARLAMA, F.FATURATUTARI, F.MAKNO, F.USER_ID, F.ISIPTAL,F.ISODENDI FROM FATURA F, SCARI S where S.EVRAKNO=F.FATURA_ID and F.FATURATIPI = 'K' and left(S.EEVRAKNO,6)='870366' order by F.FATURATARIHI DESC

    //select MAKNO, KNR, MAKBUZNO, ACIKLAMA, HNEREYEODENDI, TUTAR, MAKBUZTIPI, ODEMESEKLI, MAKBUZGRUBU, TARIH, USER_ID from KASA where MAKBUZTIPI in ('T','Ç','R') and BORCALACAK='B' and KNR='870366' order by MAKBUZNO

    //OK
    //select SNR, TANIM, GRUP, CODE, TARIH, NAME1, ADET, SATISF, SIRANO, HZLNO from HIZIL where MAKNO='3765201' order by TARIH

    //select SIRANO, TARIH, TUTAR from HUZUREVI_DETAY where MAKNO='3765201' order by TARIH desc


    //select SNR, TANIM, GRUP, CODE, TARIH, NAME1, ADET, SATISF, SIRANO from HIZIL where KNR='870366' and MAKNO='3908217' order by TARIH

    //select AK.AV_ID, A.TARIH, AK.TUTAR, A.TUTAR as ATUTAR from AVANSLAR_KULLANILAN AK, AVANSLAR A where AK.AV_ID=A.AV_ID and AK.FATURANO='1864903' order by A.TARIH desc


    // DELETE

    //DELETE DOKTORLAR_FATURA_DETAY where HAREKETTIPI='F' and FATNO='1864903'
    //UPDATE HIZIL set MAKNO=NULL where KNR='870366' and MAKNO='3908217'
    //UPDATE FATURA set ISIPTAL='1', USER_ID_UPDATE='AYDIN SAKAR', DATE_UPDATE='27.09.2011 12:51:17' where FATURA_ID='1864903'
    //DELETE from AVANSLAR_KULLANILAN where AV_ID=1767845 and FATURANO='1864903'
    //UPDATE AVANSLAR set KULLANILAN=KULLANILAN-17.5 where AV_ID=1767845


}
