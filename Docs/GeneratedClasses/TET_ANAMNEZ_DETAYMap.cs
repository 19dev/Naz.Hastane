using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class TET_ANAMNEZ_DETAYMap : ClassMap<TET_ANAMNEZ_DETAY> {
        
        public TET_ANAMNEZ_DETAYMap() {
			Table("TET_ANAMNEZ_DETAY");
			LazyLoad();
			CompositeId().KeyProperty(x => x.KNR).KeyProperty(x => x.SNR).KeyProperty(x => x.TESHISKODU).KeyProperty(x => x.GELISTARIHI);
			Map(x => x.TANITIPI).Column("TANITIPI").Length(1);
			Map(x => x.BIRINCILTANI).Column("BIRINCILTANI").Length(1);
			Map(x => x.SIRANO).Column("SIRANO").Not.Nullable();
			Map(x => x.MEDSIRANO).Column("MEDSIRANO").Length(20);
			Map(x => x.MEDONAY).Column("MEDONAY").Length(2);
			Map(x => x.MEDOZDURUM).Column("MEDOZDURUM").Not.Nullable().Length(1);
			Map(x => x.FLAG_GONDER).Column("FLAG_GONDER");
        }
    }
}
