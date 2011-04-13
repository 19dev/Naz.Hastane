using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class AVANSLAR_IADE {
        public AVANSLAR_IADE() { }
        public virtual double AV_ID { get; set; }
        public virtual string IADEMAKNO { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
    }
}
