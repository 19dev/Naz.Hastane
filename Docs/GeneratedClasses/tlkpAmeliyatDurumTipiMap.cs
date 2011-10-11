using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class tlkpAmeliyatDurumTipiMap : ClassMap<tlkpAmeliyatDurumTipi> {
        
        public tlkpAmeliyatDurumTipiMap() {
			Table("tlkpAmeliyatDurumTipi");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.Value).Column("Value").Length(50);
        }
    }
}
