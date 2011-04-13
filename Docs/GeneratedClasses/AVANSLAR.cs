using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class AVANSLAR {
        public AVANSLAR() { }
        public virtual double AV_ID { get; set; }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual double KULLANILAN { get; set; }
        public virtual double IADEEDILEN { get; set; }
        public virtual string ODEMESEKLI { get; set; }
        public virtual string POSNO { get; set; }
        public virtual string MAKNO { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public virtual string HESAPKODU { get; set; }
        public virtual string ALTHESAPKODU { get; set; }
        public virtual string TIPI { get; set; }
        public virtual string AFATNO { get; set; }
        public virtual System.Nullable<double> KALAN { get; set; }
        public virtual string AMAKNO { get; set; }
    }
}
