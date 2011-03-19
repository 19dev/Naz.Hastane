using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class PatientDiscountDetail
    {
        public virtual double ESATISF { get; set; } // ESATISF; length(8); 0
        public virtual int HI_DET_ID { get; set; } // HI_DET_ID; length(4); 0
        public virtual int HI_ID { get; set; } // HI_ID; length(4); 0
        public virtual string KNR { get; set; } // KNR; length(6); 0
        public virtual double SIRANO { get; set; } // SIRANO; length(8); 0
        public virtual string SNR { get; set; } // SNR; length(3); 0
        public virtual double YSATISF { get; set; } // YSATISF; length(8); 0
    }
}
