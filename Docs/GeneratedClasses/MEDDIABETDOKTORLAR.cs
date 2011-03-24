using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class MEDDIABETDOKTORLAR {
        public MEDDIABETDOKTORLAR() { }
        public virtual int SNO { get; set; }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual string DRTESCIL { get; set; }
        public virtual string DRBRANS { get; set; }
        public virtual string DRDM { get; set; }
    }
}
