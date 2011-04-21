using System;

namespace Naz.Hastane.Data.Entities.Accounting
{
    public class CashDeskRecord
    {
        public virtual string MAKNO { get; set; } // MAKNO; length(7); 0

        //public virtual PatientVisit PatientVisit { get; set; }
        public virtual string KNR { get; set; } // KNR; length(6); 1
        public virtual string SNR { get; set; } // SNR; length(3); 1

        public virtual DateTime? TARIH { get; set; } // TARIH; length(8); 0

        public virtual string MAKBUZNO { get; set; } // MAKBUZNO; length(20); 0
        public virtual string MAKBUZTIPI { get; set; } // MAKBUZTIPI; length(1); 0
        public virtual char ODEMESEKLI { get; set; } // ODEMESEKLI; length(1); 0
        public virtual string POSNO { get; set; } // POSNO; length(2); 1
        public virtual double TUTAR { get; set; } // TUTAR; length(8); 0
        public virtual char BORCALACAK { get; set; } // BORCALACAK; length(1); 0
        public virtual string FATURANO { get; set; } // FATURANO; length(7); 1
        public virtual string VEZNE { get; set; } // VEZNE; length(2); 0
        public virtual string HESAPKODU { get; set; } // HESAPKODU; length(50); 1
        public virtual string ALTHESAPKODU { get; set; } // ALTHESAPKODU; length(50); 1

        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0

        public virtual string ACIKLAMA { get; set; } // ACIKLAMA; length(150); 1
        public virtual string ARZT { get; set; } // ARZT; length(4); 1
        public virtual char ce { get; set; } // ce; length(1); 1
        public virtual string dovizcinsi { get; set; } // dovizcinsi; length(50); 1
        public virtual double EKSIKODENEN { get; set; } // EKSIKODENEN; length(8); 0
        public virtual string HESAPCODE { get; set; } // HESAPCODE; length(50); 1
        public virtual string HFATURANO { get; set; } // HFATURANO; length(10); 1
        public virtual string HFATURATARIHI { get; set; } // HFATURATARIHI; length(10); 1
        public virtual string HNEREYEODENDI { get; set; } // HNEREYEODENDI; length(150); 1
        public virtual string ISIPTAL { get; set; } // ISIPTAL; length(1); 1
        public virtual string KATILIM { get; set; } // KATILIM; length(1); 1
        public virtual string MAKBUZGRUBU { get; set; } // MAKBUZGRUBU; length(2); 1
        public virtual string PCARIKOD { get; set; } // PCARIKOD; length(10); 1
        public virtual string SERVIS { get; set; } // SERVIS; length(2); 1
        public virtual string TIPTAL { get; set; } // TIPTAL; length(1); 1
        public virtual double tutardoviz { get; set; } // tutardoviz; length(8); 1

        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
    }
}
