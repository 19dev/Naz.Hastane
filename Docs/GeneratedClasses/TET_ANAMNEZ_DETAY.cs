using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class TET_ANAMNEZ_DETAY {
        public TET_ANAMNEZ_DETAY() { }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual string TESHISKODU { get; set; }
        public virtual System.DateTime GELISTARIHI { get; set; }
        public virtual string TANITIPI { get; set; }
        public virtual string BIRINCILTANI { get; set; }
        public virtual int SIRANO { get; set; }
        public virtual string MEDSIRANO { get; set; }
        public virtual string MEDONAY { get; set; }
        public virtual string MEDOZDURUM { get; set; }
        public virtual System.Nullable<byte> FLAG_GONDER { get; set; }
    }
}
