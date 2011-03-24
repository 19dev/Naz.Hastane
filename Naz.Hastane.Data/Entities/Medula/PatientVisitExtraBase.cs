using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class PatientVisitExtraBase
    {
        public virtual PatientVisit PatientVisit { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PatientVisitExtraBase pv = obj as PatientVisitExtraBase;
            if (pv == null)
                return false;
            if (this.PatientVisit == pv.PatientVisit)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.PatientVisit ? 0 : this.PatientVisit.GetHashCode());

            return hash;
        }
    }
}
