using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class InsuranceCompanyDiscount
    {
        public virtual string KNR { get; set; } // KNR; length(50); 0
        public virtual string TANIM { get; set; } // TANIM; length(50); 0
        public virtual string GRUP { get; set; } // GRUP; length(50); 0

        public virtual double INDIRIMORANI { get; set; } // INDIRIMORANI; length(8); 0

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            InsuranceCompanyDetail pv = obj as InsuranceCompanyDetail;
            if (pv == null)
                return false;
            if (this.KNR == pv.KNR && this.TANIM == pv.TANIM && this.GRUP == pv.GRUP)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.KNR ? 0 : this.KNR.GetHashCode());
            hash += (null == this.TANIM ? 0 : this.TANIM.GetHashCode());
            hash += (null == this.GRUP ? 0 : this.GRUP.GetHashCode());

            return hash;
        }

    }
}
