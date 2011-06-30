using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class PersonelYabanciDilMap : ClassMap<PersonelYabanciDil> {
        
        public PersonelYabanciDilMap() {
			Table("PersonelYabanciDil");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PersonelID).Column("PersonelID").Not.Nullable();
			Map(x => x.YabanciDilID).Column("YabanciDilID").Not.Nullable();
        }
    }
}
