using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{
	public class UserPatientVisitMap : ClassMap<UserPatientVisit> 
	{
		public UserPatientVisitMap() {
			Table("tblUserPatientVisit");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.UserID).Column("UserID").Not.Nullable().Length(50);
			Map(x => x.PatientID).Column("PatientID").Not.Nullable().Length(50);
			Map(x => x.VisitDate).Column("VisitDate").Not.Nullable();
		}
	}
}
