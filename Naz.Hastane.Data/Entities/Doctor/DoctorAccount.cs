using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    /// <summary>
    /// DOKTORLAR
    /// </summary>
    public class DoctorAccount
    {
        public virtual string ADI1 { get; set; } // ADI1; length(50); 0
        public virtual string ADRZUS { get; set; } // ADRZUS; length(100); 1
        public virtual double ALACAK { get; set; } // ALACAK; length(8); 0
        public virtual string ARZT { get; set; } // ARZT; length(4); 1
        public virtual double BORC { get; set; } // BORC; length(8); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
        public virtual string DIPLOMANO { get; set; } // DIPLOMANO; length(30); 1
        public virtual double EKSIKODENEN { get; set; } // EKSIKODENEN; length(8); 0
        public virtual string FAX1 { get; set; } // FAX1; length(20); 1
        public virtual string FAX2 { get; set; } // FAX2; length(20); 1
        public virtual char HESAPTIPI { get; set; } // HESAPTIPI; length(1); 0
        public virtual double KDV { get; set; } // KDV; length(8); 0
        public virtual string KNR { get; set; } // KNR; length(5); 0
        public virtual string ORT { get; set; } // ORT; length(20); 0
        public virtual double OZELISKONTO { get; set; } // OZELISKONTO; length(8); 0
        public virtual string OZELNOT { get; set; } // OZELNOT; length(2000); 1
        public virtual string PLZ { get; set; } // PLZ; length(5); 1
        public virtual string STR { get; set; } // STR; length(30); 1
        public virtual string TEL1 { get; set; } // TEL1; length(20); 1
        public virtual string TEL2 { get; set; } // TEL2; length(20); 1
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1
        public virtual string VERDAR { get; set; } // VERDAR; length(20); 1
        public virtual string VERNO { get; set; } // VERNO; length(20); 1
    }
}
