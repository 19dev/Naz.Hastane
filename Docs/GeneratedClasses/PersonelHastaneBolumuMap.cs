using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class PersonelHastaneBolumuMap : ClassMap<PersonelHastaneBolumu> {
        
        public PersonelHastaneBolumuMap() {
			Table("PersonelHastaneBolumu");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PersonelID).Column("PersonelID").Not.Nullable();
			Map(x => x.HastaneBolumuID).Column("HastaneBolumuID").Not.Nullable();
			Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
