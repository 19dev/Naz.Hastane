using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class InsuranceCompanyDetail
    {
        public virtual string KKNR { get; set; } // KKNR; length(6); 0
        public virtual string KNR { get; set; } // KNR; length(6); 0
        public virtual string SNR { get; set; } // SNR; length(3); 0
        public virtual double SIRANO { get; set; } // SIRANO; length(8); 0

        public virtual double ADET { get; set; } // ADET; length(8); 0
        public virtual string AKOD { get; set; } // AKOD; length(2); 1
        public virtual string ARZT { get; set; } // ARZT; length(4); 0
        public virtual string ARZT2 { get; set; } // ARZT2; length(4); 0
        public virtual string CODE { get; set; } // CODE; length(15); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
        public virtual string GRUP { get; set; } // GRUP; length(3); 0
        public virtual int HZLNO { get; set; } // HZLNO; length(2); 1
        public virtual string ISLENDIMI { get; set; } // ISLENDIMI; length(2); 1
        public virtual double KDV { get; set; } // KDV; length(8); 0
        public virtual string KFATNO { get; set; } // KFATNO; length(7); 1
        public virtual double KSATISF { get; set; } // KSATISF; length(8); 0
        public virtual string MAKNO { get; set; } // MAKNO; length(8); 1
        public virtual string NAME1 { get; set; } // NAME1; length(100); 0
        public virtual string PAKET { get; set; } // PAKET; length(2); 1
        public virtual string PSG { get; set; } // PSG; length(6); 0
        public virtual double SATISF { get; set; } // SATISF; length(8); 0
        public virtual string TANIM { get; set; } // TANIM; length(2); 0
        public virtual DateTime TARIH { get; set; } // TARIH; length(8); 0
        public virtual string UNITE { get; set; } // UNITE; length(2); 1
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            InsuranceCompanyDetail pv = obj as InsuranceCompanyDetail;
            if (pv == null)
                return false;
            if (this.KKNR == pv.KKNR && this.KNR == pv.KNR && this.SNR == pv.SNR && this.SIRANO == pv.SIRANO)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.KKNR ? 0 : this.KKNR.GetHashCode());
            hash += (null == this.KNR ? 0 : this.KNR.GetHashCode());
            hash += (null == this.SNR ? 0 : this.SNR.GetHashCode());
            hash += this.SIRANO.GetHashCode();

            return hash;
        }

    }
}
