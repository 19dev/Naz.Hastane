
namespace Naz.Hastane.Data.Entities 
{
    public class LabResult 
    {
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        //public virtual string TANIM { get; set; }
        //public virtual string GRUP { get; set; }
        //public virtual string CODE { get; set; }
        //public virtual System.DateTime TARIH { get; set; }
        public virtual LabRequest LabRequest { get; set; }
        public virtual int IND { get; set; }
        
        public virtual string OZELKOD { get; set; }
        public virtual string PARISMI { get; set; }
        public virtual string SONUC { get; set; }
        public virtual string BIRIMI { get; set; }
        public virtual string NORMAL1 { get; set; }
        public virtual string NORMAL2 { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_CREATE { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LabResult lb = obj as LabResult;
            if (lb == null)
                return false;
            if (this.LabRequest == lb.LabRequest && this.IND == lb.IND)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.LabRequest ? 0 : this.LabRequest.GetHashCode());
            hash += this.IND.GetHashCode();

            return hash;
        }

    }
}
