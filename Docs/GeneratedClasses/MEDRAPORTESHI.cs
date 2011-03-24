using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class MEDRAPORTESHI {
        public MEDRAPORTESHI() { }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual System.Nullable<System.DateTime> RAPORBASTARIH { get; set; }
        public virtual System.Nullable<System.DateTime> RAPORBITTARIH { get; set; }
        public virtual string RAPORTESKOD { get; set; }
        public virtual string RAPORACIKLAMA { get; set; }
        public virtual string ICD10TANIKODU { get; set; }
    }
}
