using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LabDefinition {
        public LabDefinition() { }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual int IND { get; set; }
        public virtual string PARISMI { get; set; }
        public virtual string BIRIMI { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string TEXT { get; set; }
        public virtual string MEDTAHLILKODU { get; set; }
        public virtual string MEDGONDER { get; set; }
    }
}
