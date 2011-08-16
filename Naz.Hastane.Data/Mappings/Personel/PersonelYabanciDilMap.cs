using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{
        
    public class PersonelYabanciDilMap : ClassMap<PersonelYabanciDil> 
    {
        
        public PersonelYabanciDilMap() 
        {
            Table("tblPersonelYabanciDil");
            LazyLoad();
            Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.Personel).Column("PersonelID").Not.Nullable();
            References(x => x.YabanciDil).Column("YabanciDilID").Not.Nullable();
            References(x => x.OkumaDerecesi).Column("OkumaDerecesi");
            References(x => x.YazmaDerecesi).Column("YazmaDerecesi");
            References(x => x.KonusmaDerecesi).Column("KonusmaDerecesi");
            Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
