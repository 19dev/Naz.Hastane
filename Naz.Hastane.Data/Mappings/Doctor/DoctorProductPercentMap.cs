using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class HIZMETDOKTORYUZDEMap : ClassMap<DoctorProductPercent> {
        
        public HIZMETDOKTORYUZDEMap() {

            Table("HIZMETDOKTORYUZDE");
			
            LazyLoad();
			
            CompositeId()
                .KeyProperty(x => x.TANIM)
                .KeyProperty(x => x.GRUP)
                .KeyProperty(x => x.CODE)
                .KeyProperty(x => x.ARZT);
			
            Map(x => x.YUZDE).Column("YUZDE").Not.Nullable();
        }
    }
}
