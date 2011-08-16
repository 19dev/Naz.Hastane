using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{    
    
    public class PersonelHastaneBolumuMap : ClassMap<PersonelHastaneBolumu> 
    {
        
        public PersonelHastaneBolumuMap() {
			Table("tblPersonelHastaneBolumu");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.Personel).Column("PersonelID").Not.Nullable();
            References(x => x.HastaneBolumu).Column("HastaneBolumuID");
			Map(x => x.BaslangicTarihi).Column("BaslangicTarihi");
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
