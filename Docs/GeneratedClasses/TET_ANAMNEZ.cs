using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class TET_ANAMNEZ {
        public TET_ANAMNEZ() { }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual System.DateTime GELIS_TARIHI { get; set; }
        public virtual string OZSOYGECMIS { get; set; }
        public virtual string SISTEMSORGULARI { get; set; }
        public virtual string MUAYENEBULGULARI { get; set; }
        public virtual string ONTANI { get; set; }
        public virtual string TESHISVETEDAVI { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public virtual string DOKTOR { get; set; }
        public virtual string SERVIS { get; set; }
        public virtual string PROTNO { get; set; }
        public virtual string OYKU { get; set; }
        public virtual string YAKINMA { get; set; }
        public virtual string NOTLAR { get; set; }
        public virtual System.Nullable<System.DateTime> MUAYENE_TARIHI { get; set; }
    }
}
