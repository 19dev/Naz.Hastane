using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDDIABETHASTALIKLARMap : ClassMap<MEDDIABETHASTALIKLAR> {
        
        public MEDDIABETHASTALIKLARMap() {
			Table("MEDDIABETHASTALIKLAR");
			LazyLoad();
			Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");
			Map(x => x.KNR).Column("KNR").Length(6);
			Map(x => x.SNR).Column("SNR").Length(3);
			Map(x => x.HASTALIKKODU).Column("HASTALIKKODU").Length(10);
			Map(x => x.HASTALIKTANIKODU).Column("HASTALIKTANIKODU").Length(10);
        }
    }
}
