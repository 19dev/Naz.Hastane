namespace Naz.Hastane.Data.Entities 
{
    public class MEDDIABETHASTALIKLAR 
    {
        public virtual int SNO { get; set; }

        public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        public virtual string HASTALIKKODU { get; set; }
        public virtual string HASTALIKTANIKODU { get; set; }
    }
}
