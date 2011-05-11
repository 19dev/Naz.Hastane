using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class LOGTCKIMLIKNOSORGUMap : ClassMap<LOGTCKIMLIKNOSORGU> {
        
        public LOGTCKIMLIKNOSORGUMap() {
			Table("LOGTCKIMLIKNOSORGU");
			LazyLoad();
			CompositeId();
			Map(x => x.SIRA).Column("SIRA").Not.Nullable();
			Map(x => x.TCKIMLIKNO).Column("TCKIMLIKNO").Length(50);
			Map(x => x.HASTAADI).Column("HASTAADI").Length(50);
			Map(x => x.HASTASOYADI).Column("HASTASOYADI").Length(50);
			Map(x => x.TARIH).Column("TARIH");
			Map(x => x.TCUSERID).Column("TCUSERID").Length(50);
        }
    }
}
