using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class HIZMETDOKTORYUZDE {
        public HIZMETDOKTORYUZDE() { }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string ARZT { get; set; }
        public virtual double YUZDE { get; set; }
    }
}
