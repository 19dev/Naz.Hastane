namespace Naz.Hastane.Data.Entities 
{
    public class PatientAnamnesisDetail
    {
        /// <summary>
        /// KNR, SNR, GELIS_TARIHI (BEHAND_DETAY, TET_ANAMNEZ)
        /// </summary>
        public virtual PatientAnamnesis PatientAnamnesis { get; set; }
        public virtual string TESHISKODU { get; set; }
  
        public virtual string TANITIPI { get; set; }
        public virtual string BIRINCILTANI { get; set; }
        public virtual int SIRANO { get; set; }
        public virtual string MEDSIRANO { get; set; }
        public virtual string MEDONAY { get; set; }
        public virtual string MEDOZDURUM { get; set; }
        public virtual System.Nullable<byte> FLAG_GONDER { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PatientAnamnesisDetail pa = obj as PatientAnamnesisDetail;
            if (pa == null)
                return false;
            if (this.PatientAnamnesis == pa.PatientAnamnesis && this.TESHISKODU == pa.TESHISKODU)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.PatientAnamnesis ? 0 : this.PatientAnamnesis.GetHashCode());
            hash += (null == this.TESHISKODU ? 0 : this.TESHISKODU.GetHashCode());

            return hash;
        }

    }
}
