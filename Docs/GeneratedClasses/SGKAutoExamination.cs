using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class SGKAutoExamination {
        public SGKAutoExamination() { }
        public virtual string SERVISKODU { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string KATILIM { get; set; }
        public virtual string AYKATILIM { get; set; }
    }
}
