using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class InvoiceTemp
    {
        public virtual double ADET { get; set; } // ADET; length(8); 1
        public virtual string CODE { get; set; } // CODE; length(15); 1
        public virtual string FATURA_ID { get; set; } // FATURA_ID; length(20); 1
        public virtual string GRUP { get; set; } // GRUP; length(3); 1
        public virtual double KDV { get; set; } // KDV; length(8); 1
        public virtual string KNR { get; set; } // KNR; length(6); 1
        public virtual string NAME1 { get; set; } // NAME1; length(250); 1
        public virtual string PROVIZYONNO { get; set; } // PROVIZYONNO; length(50); 1
        public virtual string PSG { get; set; } // PSG; length(6); 1
        public virtual double SATISF { get; set; } // SATISF; length(8); 1
        public virtual double SIRAID { get; set; } // SIRAID; length(8); 1
        public virtual string SNR { get; set; } // SNR; length(3); 1
        public virtual string TANIM { get; set; } // TANIM; length(2); 1
        public virtual DateTime TARIH1 { get; set; } // TARIH1; length(8); 1
        public virtual DateTime TARIH2 { get; set; } // TARIH2; length(8); 1
        public virtual double TUTAR { get; set; } // TUTAR; length(8); 1
        public virtual string USER_ID { get; set; } // USER_ID; length(100); 1
        public virtual string YAZIYLA { get; set; } // YAZIYLA; length(150); 1
    }
}
