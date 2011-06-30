using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class PersonelSertifikaMap : ClassMap<PersonelSertifika> {
        
        public PersonelSertifikaMap() {
			Table("PersonelSertifika");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.PersonelID).Column("PersonelID").Not.Nullable();
			Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
			Map(x => x.BitisTarihi).Column("BitisTarihi").Not.Nullable();
			Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
