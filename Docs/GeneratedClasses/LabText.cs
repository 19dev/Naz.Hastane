using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LabText {
        public LabText() { }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual string LABTEXT { get; set; }
    }
}
