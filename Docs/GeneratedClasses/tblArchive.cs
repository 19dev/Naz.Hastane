using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class tblArchive {
        public tblArchive() { }
        public virtual int ID { get; set; }
        public virtual string PatientNo { get; set; }
        public virtual System.Nullable<long> Yer { get; set; }
        public virtual System.Nullable<long> Oda { get; set; }
        public virtual System.Nullable<long> Raf { get; set; }
        public virtual System.Nullable<long> Kutu { get; set; }
        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }
    }
}
