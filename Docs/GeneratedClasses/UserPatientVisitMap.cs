using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class UserPatientVisitMap : ClassMap<UserPatientVisit> {
        
        public UserPatientVisitMap() {
			Table("UserPatientVisit");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.UserID).Column("UserID").Not.Nullable().Length(50);
			Map(x => x.PatientID).Column("PatientID").Not.Nullable().Length(50);
			Map(x => x.VisitDate).Column("VisitDate").Not.Nullable();
        }
    }
}
