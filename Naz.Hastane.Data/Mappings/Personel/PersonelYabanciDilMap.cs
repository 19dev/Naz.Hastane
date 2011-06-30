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
            Map(x => x.PersonelID).Column("PersonelID").Not.Nullable();
            Map(x => x.YabanciDilID).Column("YabanciDilID").Not.Nullable();
        }
    }
}
