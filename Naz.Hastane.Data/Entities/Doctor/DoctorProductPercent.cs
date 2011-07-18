namespace Naz.Hastane.Data.Entities 
{
    public class DoctorProductPercent 
    {
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string ARZT { get; set; }

        public virtual double YUZDE { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            DoctorProductPercent dpp = obj as DoctorProductPercent;
            if (dpp == null)
                return false;
            //if (this.PatientVisit == pv.KNR && this.SNR == pv.SNR && this.DetailNo == pv.DetailNo)
            if (this.TANIM == dpp.TANIM && this.GRUP == dpp.GRUP && this.CODE == dpp.CODE && this.ARZT == dpp.ARZT)
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
            hash += (null == this.ARZT ? 0 : this.ARZT.GetHashCode());
            return hash;
        }
    }
}
