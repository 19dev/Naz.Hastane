using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDDIABETDOKTORLARMap : ClassMap<MEDDIABETDOKTORLAR> {
        
        public MEDDIABETDOKTORLARMap() {
			Table("MEDDIABETDOKTORLAR");
			LazyLoad();
			Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");
			Map(x => x.KNR).Column("KNR").Length(6);
			Map(x => x.SNR).Column("SNR").Length(3);
			Map(x => x.DRTESCIL).Column("DRTESCIL").Length(20);
			Map(x => x.DRBRANS).Column("DRBRANS").Length(4);
			Map(x => x.DRDM).Column("DRDM").Length(1);
        }
    }
}
