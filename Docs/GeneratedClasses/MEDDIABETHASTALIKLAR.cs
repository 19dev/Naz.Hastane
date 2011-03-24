using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class MEDDIABETHASTALIKLAR {
        public MEDDIABETHASTALIKLAR() { }
        public virtual int SNO { get; set; }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual string HASTALIKKODU { get; set; }
        public virtual string HASTALIKTANIKODU { get; set; }
    }
}
