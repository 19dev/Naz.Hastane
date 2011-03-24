using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class MEDRAPORDOKTOR 
    {

        public MEDRAPORDOKTOR() { }
        
        public virtual int SNO { get; set; }
        
        public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        public virtual string DRAD { get; set; }
        public virtual string DRSOYAD { get; set; }
        public virtual string BRANS { get; set; }
        public virtual string TESCILNO { get; set; }
        public virtual string TIPI { get; set; }
    }
}
