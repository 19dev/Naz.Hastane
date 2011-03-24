using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDDIABETALISKANLIKLARMap : ClassMap<MEDDIABETALISKANLIKLAR> {
        
        public MEDDIABETALISKANLIKLARMap() {
			Table("MEDDIABETALISKANLIKLAR");
			LazyLoad();
			Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");
			Map(x => x.KNR).Column("KNR").Length(6);
			Map(x => x.SNR).Column("SNR").Length(3);
			Map(x => x.ALISKANLIKKODU).Column("ALISKANLIKKODU").Length(2);
        }
    }
}
