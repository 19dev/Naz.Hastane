using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{   
    public class PersonelEgitimMap : ClassMap<PersonelEgitim> 
    {
        public PersonelEgitimMap() 
        {
			Table("tblPersonelEgitim");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			References(x => x.Personel).Column("PersonelID").Not.Nullable();
			References(x => x.OkulTipi).Column("OkulTipiID").Not.Nullable();
            Map(x => x.OkulAdi).Column("OkulAdi");
            Map(x => x.BaslangicTarihi).Column("BaslangicTarihi");
			Map(x => x.BitisTarihi).Column("BitisTarihi");
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
