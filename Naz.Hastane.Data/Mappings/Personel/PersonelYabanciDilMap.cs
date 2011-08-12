using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{
        
    public class PersonelYabanciDilMap : ClassMap<PersonelYabanciDil> 
    {
        
        public PersonelYabanciDilMap() 
        {
            Table("PersonelYabanciDil");
            LazyLoad();
            Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.Personel).Column("PersonelID").Not.Nullable();
            References(x => x.YabanciDil).Column("YabanciDilID").Not.Nullable();
        }
    }
}
