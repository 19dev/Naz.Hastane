using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{
        
    public class PersonelHizmetIciEgitimMap : ClassMap<PersonelHizmetIciEgitim> 
    {
        
        public PersonelHizmetIciEgitimMap() 
        {
			Table("PersonelHizmetIciEgitim");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.Personel).Column("PersonelID").Not.Nullable();
            Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
			Map(x => x.BitisTarihi).Column("BitisTarihi").Not.Nullable();
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
