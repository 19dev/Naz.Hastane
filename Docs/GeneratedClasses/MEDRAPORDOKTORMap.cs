using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDRAPORDOKTORMap : ClassMap<MEDRAPORDOKTOR> {
        
        public MEDRAPORDOKTORMap() {
			Table("MEDRAPORDOKTOR");
			LazyLoad();
			CompositeId();
			Map(x => x.SNO).Column("SNO").Not.Nullable();
			Map(x => x.KNR).Column("KNR").Length(6);
			Map(x => x.SNR).Column("SNR").Length(3);
			Map(x => x.DRAD).Column("DRAD").Length(50);
			Map(x => x.DRSOYAD).Column("DRSOYAD").Length(50);
			Map(x => x.BRANS).Column("BRANS").Length(10);
			Map(x => x.TESCILNO).Column("TESCILNO").Length(20);
			Map(x => x.TIPI).Column("TIPI").Length(10);
        }
    }
}
