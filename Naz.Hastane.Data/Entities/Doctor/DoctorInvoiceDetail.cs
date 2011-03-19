using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class DoctorInvoiceDetail
    {
        public virtual char AMBU { get; set; } // AMBU; length(1); 0
        public virtual int CARI_ID { get; set; } // CARI_ID; length(4); 1
        public virtual string CODE { get; set; } // CODE; length(15); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual int DETAY_ID { get; set; } // DETAY_ID; length(4); 0
        public virtual string FATNO { get; set; } // FATNO; length(15); 0
        public virtual string FATURANO { get; set; } // FATURANO; length(15); 0
        public virtual DateTime FATURATARIHI { get; set; } // FATURATARIHI; length(8); 0
        public virtual string FATURATIPI { get; set; } // FATURATIPI; length(1); 1
        public virtual string GRUP { get; set; } // GRUP; length(3); 0
        public virtual char HAREKETTIPI { get; set; } // HAREKETTIPI; length(1); 0
        public virtual string HKNR { get; set; } // HKNR; length(6); 0
        public virtual double HSIRANO { get; set; } // HSIRANO; length(8); 1
        public virtual string HSNR { get; set; } // HSNR; length(3); 1
        public virtual char ISODENDI { get; set; } // ISODENDI; length(1); 0
        public virtual string KNR { get; set; } // KNR; length(5); 0
        public virtual string MAKBUZNO { get; set; } // MAKBUZNO; length(10); 1
        public virtual string MAKNO { get; set; } // MAKNO; length(10); 1
        public virtual double PAY { get; set; } // PAY; length(8); 0
        public virtual double PAY_YEDEK { get; set; } // PAY_YEDEK; length(8); 1
        public virtual int SIRA { get; set; } // SIRA; length(4); 0
        public virtual string TANIM { get; set; } // TANIM; length(2); 0
        public virtual double TOPLAM { get; set; } // TOPLAM; length(8); 0
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
    }
}
