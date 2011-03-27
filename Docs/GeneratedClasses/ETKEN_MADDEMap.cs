using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class ETKEN_MADDEMap : ClassMap<ETKEN_MADDE> {
        
        public ETKEN_MADDEMap() {
			Table("ETKEN_MADDE");
			LazyLoad();
			Id(x => x.KODU).GeneratedBy.Assigned().Column("KODU");
			Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(100);
			Map(x => x.ICERIK).Column("ICERIK").Length(50);
			Map(x => x.FORM).Column("FORM").Length(50);
			Map(x => x.MIKTAR).Column("MIKTAR").Length(50);
        }
    }
}
