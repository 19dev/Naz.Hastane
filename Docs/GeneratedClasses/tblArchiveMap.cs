using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class tblArchiveMap : ClassMap<tblArchive> {
        
        public tblArchiveMap() {
			Table("tblArchive");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PatientNo).Column("PatientNo").Length(6);
			Map(x => x.Yer).Column("Yer").Length(10);
			Map(x => x.Oda).Column("Oda").Length(10);
			Map(x => x.Raf).Column("Raf").Length(10);
			Map(x => x.Kutu).Column("Kutu").Length(10);
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
        }
    }
}
