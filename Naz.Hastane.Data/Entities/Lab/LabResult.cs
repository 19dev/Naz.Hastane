
namespace Naz.Hastane.Data.Entities 
{
    public class LabResult 
    {
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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LabResult lb = obj as LabResult;
            if (lb == null)
                return false;
            if (this.TANIM == lb.TANIM && this.GRUP == lb.GRUP && this.CODE == lb.CODE && this.KNR == lb.KNR && this.SNR == lb.SNR && this.TARIH == lb.TARIH && this.IND == lb.IND)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.TANIM ? 0 : this.TANIM.GetHashCode());
            hash += (null == this.GRUP ? 0 : this.GRUP.GetHashCode());
            hash += (null == this.CODE ? 0 : this.CODE.GetHashCode());
            hash += (null == this.KNR ? 0 : this.KNR.GetHashCode());
            hash += (null == this.SNR ? 0 : this.SNR.GetHashCode());
            hash += (null == this.TARIH ? 0 : this.TARIH.GetHashCode());
            hash += (null == this.IND ? 0 : this.IND.GetHashCode());

            return hash;
        }

    }
}
