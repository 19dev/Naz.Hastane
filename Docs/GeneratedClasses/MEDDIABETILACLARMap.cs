using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDDIABETILACLARMap : ClassMap<MEDDIABETILACLAR> {
        
        public MEDDIABETILACLARMap() {
			Table("MEDDIABETILACLAR");
			LazyLoad();
			Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");
			Map(x => x.KNR).Column("KNR").Length(6);
			Map(x => x.SNR).Column("SNR").Length(3);
			Map(x => x.ILACKODU).Column("ILACKODU").Length(50);
			Map(x => x.GUNLUKDOZ).Column("GUNLUKDOZ").Length(50);
        }
    }
}
