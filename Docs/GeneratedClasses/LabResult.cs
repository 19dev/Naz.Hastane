using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LabResult {
        public LabResult() { }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual int IND { get; set; }
        public virtual string OZELKOD { get; set; }
        public virtual string PARISMI { get; set; }
        public virtual string SONUC { get; set; }
        public virtual string BIRIMI { get; set; }
        public virtual string NORMAL1 { get; set; }
        public virtual string NORMAL2 { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_CREATE { get; set; }
    }
}
