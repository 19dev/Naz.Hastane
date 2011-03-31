using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.StoredProcedure
{
    public class AccountingDailySummary
    {
        [Description("Sıra No")]
        public virtual int RowNumber { get; set; }
        [Description("Ödeme Şekli")]
        public virtual string OdemeSekli { get; set; }
        [Description("Tarih")]
        public virtual DateTime Tarih { get; set; }
        [Description("T.C. Kimlik No")]
        public virtual string TCKIMLIKNO { get; set; }
        [Description("Hesap Kodu")]
        public virtual string HesapKodu { get; set; }
        [Description("Açıklama")]
        public virtual string Aciklama { get; set; }
        [Description("Makbuz No")]
        public virtual string MakbuzNo { get; set; }
        [Description("Tutar")]
        public virtual double Tutar { get; set; }
        [Description("Fatura Tutarı")]
        public virtual double HizmetTutari { get; set; }
        [Description("KDV Oranı")]
        public virtual int KDVOrani { get; set; }
        [Description("Fiş Tipi")]
        public virtual string RecordType { get; set; }
    }
}
