using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class PatientContribution
    {
        public virtual string PatientNo { get; set; } // KNR; length(6); 0
        public virtual string ORAN1 { get; set; } // ORAN1; length(150); 1
        public virtual string ORAN2 { get; set; } // ORAN2; length(150); 1
    }
}
