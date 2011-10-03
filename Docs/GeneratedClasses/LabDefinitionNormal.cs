using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LabDefinitionNormal {
        public LabDefinitionNormal() { }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual int IND { get; set; }
        public virtual System.Nullable<int> SIRA { get; set; }
        public virtual string CINSIYET { get; set; }
        public virtual string DMY { get; set; }
        public virtual System.Nullable<int> DMY1 { get; set; }
        public virtual System.Nullable<int> DMY2 { get; set; }
        public virtual string NORMAL1 { get; set; }
        public virtual string NORMAL2 { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string PANIK1 { get; set; }
        public virtual string PANIK2 { get; set; }
    }
}
