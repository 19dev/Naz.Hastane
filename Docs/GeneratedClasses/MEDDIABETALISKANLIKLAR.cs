using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class MEDDIABETALISKANLIKLAR {
        public MEDDIABETALISKANLIKLAR() { }
        public virtual int SNO { get; set; }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual System.Nullable<long> ALISKANLIKKODU { get; set; }
    }
}
