using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class StockTransfer {
        public StockTransfer() { }
        public virtual long SH_ID { get; set; }
        public virtual string AKOD { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual System.DateTime TARIH { get; set; }
        public virtual string FIRMA { get; set; }
        public virtual string EVRAKNO { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string G_C { get; set; }
        public virtual double ADET { get; set; }
        public virtual double BIRIMF { get; set; }
        public virtual double TUTAR { get; set; }
        public virtual string SERVIS { get; set; }
        public virtual string ARZT { get; set; }
        public virtual string DURUM { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
        public virtual System.Nullable<double> KALAN { get; set; }
        public virtual System.Nullable<System.DateTime> MIADTARIHI { get; set; }
    }
}
