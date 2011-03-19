using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class PatientDiscount
    {
        public virtual string ARZT { get; set; } // ARZT; length(4); 0
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual double HASTATOPLAM { get; set; } // HASTATOPLAM; length(8); 0
        public virtual int HI_ID { get; set; } // HI_ID; length(4); 0
        public virtual string INDIRIMACIKLAMA { get; set; } // INDIRIMACIKLAMA; length(100); 1
        public virtual string INDIRIMNEDEN { get; set; } // INDIRIMNEDEN; length(4); 0
        public virtual double INDIRIMTOPLAM { get; set; } // INDIRIMTOPLAM; length(8); 0
        public virtual double INDIRIMYUZDE { get; set; } // INDIRIMYUZDE; length(8); 0
        public virtual string KNR { get; set; } // KNR; length(6); 0
        public virtual string MAKNO { get; set; } // MAKNO; length(8); 1
        public virtual double SECILITOPLAM { get; set; } // SECILITOPLAM; length(8); 0
        public virtual string SNR { get; set; } // SNR; length(3); 0
        public virtual double SONTOPLAM { get; set; } // SONTOPLAM; length(8); 0
        public virtual DateTime TARIH { get; set; } // TARIH; length(4); 0
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
    }
}
