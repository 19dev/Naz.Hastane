using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class UserPatientVisit {
        public UserPatientVisit() { }
        public virtual int ID { get; set; }
        public virtual string UserID { get; set; }
        public virtual string PatientID { get; set; }
        public virtual System.DateTime VisitDate { get; set; }
    }
}
