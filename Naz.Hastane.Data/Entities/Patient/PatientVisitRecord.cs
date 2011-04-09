using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class PatientVisitRecord
    {
        public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual string KNR { get; set; } // KNR; length(6); 0
        //public virtual string SNR { get; set; } // SNR; length(3); 0
        /// <summary>
        /// GELISTARIHI
        /// </summary>
        public virtual DateTime VisitDate { get; set; } // GELISTARIHI; length(8); 0
        /// <summary>
        /// AZT
        /// </summary>
        public virtual string Doctor { get; set; } // ARZT; length(4); 0
        /// <summary>
        /// SERVIS
        /// </summary>
        public virtual string Servis { get; set; } // SERVIS; length(2); 0
        /// <summary>
        /// SERNO
        /// </summary>
        public virtual string QueueNo { get; set; } // SERNO; length(5); 1
        /// <summary>
        /// AMBU
        /// </summary>
        public virtual string VisitType { get; set; } // AMBU; length(1); 0

        public virtual char ACIL_KONS { get; set; } // ACIL_KONS; length(1); 1
        public virtual string BRANSKODU { get; set; } // BRANSKODU; length(10); 1
        public virtual string EKSORGU { get; set; } // EKSORGU; length(1); 1
        public virtual char GELMEDİ { get; set; } // GELMEDİ; length(1); 1
        public virtual string GOZ_NOTLAR { get; set; } // GOZ_NOTLAR; length(100); 1
        public virtual string HASTABASNO { get; set; } // HASTABASNO; length(10); 1
        public virtual string ILISKILITAKIPNO { get; set; } // ILISKILITAKIPNO; length(20); 1
        public virtual string ISTEM_ARZT { get; set; } // ISTEM_ARZT; length(4); 1
        public virtual string ISTISNAIDURUM { get; set; } // ISTISNAIDURUM; length(2); 1
        public virtual char KONS { get; set; } // KONS; length(1); 1
        public virtual string KONS_SNR { get; set; } // KONS_SNR; length(3); 1
        public virtual DateTime? KONS_TARIH { get; set; } // KONS_TARIH; length(8); 1
        public virtual string KONT { get; set; } // KONT; length(1); 1
        public virtual int KONTROL_ID { get; set; } // KONTROL_ID; length(9); 1
        public virtual DateTime? MCIKISTARIHI { get; set; } // MCIKISTARIHI; length(8); 1
        public virtual string MUAYENEOLDU { get; set; } // MUAYENEOLDU; length(1); 0
        public virtual string NOTLAR { get; set; } // NOTLAR; length(100); 1
        public virtual string ONERILER { get; set; } // ONERILER; length(100); 1
        public virtual string PSG { get; set; } // PSG; length(10); 1
        public virtual string SEVKTAKIPNO { get; set; } // SEVKTAKIPNO; length(10); 1
        public virtual string SIGORTALIKARTNO { get; set; } // SIGORTALIKARTNO; length(20); 1
        public virtual string TABKODU { get; set; } // TABKODU; length(2); 1
        public virtual string TAKIPTIPI { get; set; } // TAKIPTIPI; length(10); 1
        public virtual string TAKIPTURU { get; set; } // TAKIPTURU; length(10); 1
        public virtual string TEDAVITIPI { get; set; } // TEDAVITIPI; length(10); 1
        public virtual string TEDAVITURU { get; set; } // TEDAVITURU; length(10); 1

        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0

        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PatientVisitRecord pv = obj as PatientVisitRecord;
            if (pv == null)
                return false;
            if (this.PatientVisit == pv.PatientVisit && this.VisitDate == pv.VisitDate)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += this.PatientVisit.GetHashCode();
            hash += this.VisitDate.GetHashCode();

            return hash;
        }

    }
}
