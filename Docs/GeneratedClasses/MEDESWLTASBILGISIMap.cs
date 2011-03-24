using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDESWLTASBILGISIMap : ClassMap<MEDESWLTASBILGISI> {
        
        public MEDESWLTASBILGISIMap() {
			Table("MEDESWLTASBILGISI");
			LazyLoad();
			CompositeId();
			Map(x => x.SNO).Column("SNO").Not.Nullable();
			Map(x => x.KNR).Column("KNR").Length(10);
			Map(x => x.SNR).Column("SNR").Length(10);
			Map(x => x.ESWLTASBOYUTU).Column("ESWLTASBOYUTU").Length(10);
			Map(x => x.ESWLTASLOKKODU).Column("ESWLTASLOKKODU").Length(10);
        }
    }
}
