using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class LabRequest {
        public LabRequest() { }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string KNR { get; set; }
        public virtual string SNR { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual IList<LABORSONUC> LABORSONUCS { get; set; }
        public virtual IList<LABORSONUC> LABORSONUCS { get; set; }
        public virtual IList<LABORSONUC> LABORSONUCS { get; set; }
        public virtual IList<LABORSONUC> LABORSONUCS { get; set; }
        public virtual IList<LABORSONUC> LABORSONUCS { get; set; }
        public virtual IList<LABORSONUC> LABORSONUCS { get; set; }
        public virtual IList<LABORTEXT> LABORTEXTS { get; set; }
        public virtual IList<LABORTEXT> LABORTEXTS { get; set; }
        public virtual IList<LABORTEXT> LABORTEXTS { get; set; }
        public virtual IList<LABORTEXT> LABORTEXTS { get; set; }
        public virtual IList<LABORTEXT> LABORTEXTS { get; set; }
        public virtual IList<LABORTEXT> LABORTEXTS { get; set; }
        public virtual string TOOLTIPTEXT { get; set; }
        public virtual string KABUL { get; set; }
        public virtual string KABUL_ID { get; set; }
        public virtual System.Nullable<System.DateTime> KABUL_TARIH { get; set; }
        public virtual string KABUL_NO { get; set; }
        public virtual string DISMERKEZ { get; set; }
        public virtual string ONAY { get; set; }
        public virtual string ONAY_ID { get; set; }
        public virtual System.Nullable<System.DateTime> ONAY_TARIH { get; set; }
        public virtual string DRONAY { get; set; }
        public virtual string DRONAY_ID { get; set; }
        public virtual System.Nullable<System.DateTime> DRONAY_TARIH { get; set; }
        public virtual string YAZILDIMI { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> ORNEK_TARIHI { get; set; }
    }
}
