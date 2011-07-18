namespace Naz.Hastane.Data.Entities 
{
    public class MEDESWLTASBILGISI 
    {
        public virtual int SNO { get; set; }

        public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual System.Nullable<long> KNR { get; set; }
        //public virtual System.Nullable<long> SNR { get; set; }
        public virtual System.Nullable<long> ESWLTASBOYUTU { get; set; }
        public virtual System.Nullable<long> ESWLTASLOKKODU { get; set; }
    }
}
