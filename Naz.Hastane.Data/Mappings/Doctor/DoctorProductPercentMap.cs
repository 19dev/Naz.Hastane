using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class DoctorProductPercentMap : ClassMap<DoctorProductPercent> {
        
        public DoctorProductPercentMap() {

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
