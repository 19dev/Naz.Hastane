using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class DoctorPool
    {
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual int HAVUZ_ID { get; set; } // HAVUZ_ID; length(4); 0
        public virtual string HKNR { get; set; } // HKNR; length(6); 0
        public virtual char ISODENDI { get; set; } // ISODENDI; length(1); 0
        public virtual string KNR { get; set; } // KNR; length(6); 0
        public virtual double PAY { get; set; } // PAY; length(8); 0
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
    }
}
