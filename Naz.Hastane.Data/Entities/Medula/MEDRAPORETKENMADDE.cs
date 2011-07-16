namespace Naz.Hastane.Data.Entities 
{
    public class MEDRAPORETKENMADDE : PatientVisitExtraBase
    {
        //public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        public virtual string ETKENKODU { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string KULLANIMDOZ1 { get; set; }
        public virtual string KULLANIMDOZ2 { get; set; }
        public virtual string KULLANIMDOZBIRIM { get; set; }
        public virtual string KULLANIMPERIYOT { get; set; }
        public virtual string KULLANIMPERIYOTBIRIM { get; set; }
        public virtual System.Nullable<byte> FLAG_GONDER { get; set; }
    }
}
