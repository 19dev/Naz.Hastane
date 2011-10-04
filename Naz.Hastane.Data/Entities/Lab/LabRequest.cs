
namespace Naz.Hastane.Data.Entities 
{
    public class LabRequest 
    {
        //public virtual string TANIM { get; set; }
        //public virtual string GRUP { get; set; }
        //public virtual string CODE { get; set; }
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        public virtual Product Product { get; set; }
        public virtual PatientVisit PatientVisit { get; set; }
        public virtual System.DateTime TARIH { get; set; }

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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LabRequest lb = obj as LabRequest;
            if (lb == null)
                return false;
            if (this.Product == lb.Product && this.PatientVisit == lb.PatientVisit && this.TARIH == lb.TARIH)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.Product ? 0 : this.Product.GetHashCode());
            hash += (null == this.PatientVisit ? 0 : this.PatientVisit.GetHashCode());
            hash += (null == this.TARIH ? 0 : this.TARIH.GetHashCode());

            return hash;
        }

    }
}
