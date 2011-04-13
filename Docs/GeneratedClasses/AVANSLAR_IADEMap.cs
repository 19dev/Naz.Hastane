using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class AVANSLAR_IADEMap : ClassMap<AVANSLAR_IADE> {
        
        public AVANSLAR_IADEMap() {
			Table("AVANSLAR_IADE");
			LazyLoad();
			CompositeId().KeyProperty(x => x.AV_ID).KeyProperty(x => x.IADEMAKNO);
			Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.TUTAR).Column("TUTAR").Not.Nullable();
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
        }
    }
}
