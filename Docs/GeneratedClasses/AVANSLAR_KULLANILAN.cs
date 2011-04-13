using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class AVANSLAR_KULLANILAN {
        public AVANSLAR_KULLANILAN() { }
        public virtual double AV_ID { get; set; }
        public virtual string FATURANO { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
    }
}
