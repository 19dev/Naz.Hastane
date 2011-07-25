namespace Naz.Hastane.Data.Entities 
{
    public class UserPatientVisit 
    {
        public virtual int ID { get; set; }
        public virtual string UserID { get; set; }
        public virtual string PatientID { get; set; }
        public virtual System.DateTime VisitDate { get; set; }
    }
}
