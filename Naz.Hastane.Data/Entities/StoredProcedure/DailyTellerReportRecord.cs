using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.StoredProcedure
{
    [Description("Günlük Vezne Raporu")]
    public class DailyTellerReportRecord
    {
        [Description("Sıra No")]
        public virtual int RowNumber { get; set; }
        [Description("Tarih")]
        public virtual DateTime Date { get; set; }
        [Description("Ödeme Yeri")]
        public virtual string Description { get; set; }
        [Description("Makbuz No")]
        public virtual string TellerVoucherNo { get; set; }
        [Description("Ödeme Şekli")]
        public virtual string PaymentType { get; set; }
        [Description("Tutar")]
        public virtual double Payment { get; set; }
        [Description("Borç/Alacak")]
        public virtual string RecordType { get; set; }
        [Description("Kullanıcı")]
        public virtual string USER_ID { get; set; }
        [Description("Açıklama")]
        public virtual string Aciklama { get; set; }
        [Description("Giren Tutar")]
        public virtual double GirenTutar { get; set; }
        [Description("Çıkan Tutar")]
        public virtual double CikanTutar { get; set; }
        [Description("Hasta Adı")]
        public virtual string PatientFirstName { get; set; }
        [Description("Hasta Soyadı")]
        public virtual string PatientLastName { get; set; }
        [Description("Protokol No")]
        public virtual string PatientNo { get; set; }
        [Description("T.C. Kimlik No")]
        public virtual string TCID { get; set; }
    }
}
