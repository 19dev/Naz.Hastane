using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class MEDESWLTASBILGISI {
        public MEDESWLTASBILGISI() { }
        public virtual int SNO { get; set; }
        public virtual System.Nullable<long> KNR { get; set; }
        public virtual System.Nullable<long> SNR { get; set; }
        public virtual System.Nullable<long> ESWLTASBOYUTU { get; set; }
        public virtual System.Nullable<long> ESWLTASLOKKODU { get; set; }
    }
}
