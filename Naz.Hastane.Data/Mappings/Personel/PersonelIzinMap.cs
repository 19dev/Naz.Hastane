using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{    
    
    public class PersonelIzinMap : ClassMap<PersonelIzin> 
    {
        
        public PersonelIzinMap() 
        {
			Table("PersonelIzin");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PersonelID).Column("PersonelID").Not.Nullable();
			Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
			Map(x => x.BitisTarihi).Column("BitisTarihi");
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
