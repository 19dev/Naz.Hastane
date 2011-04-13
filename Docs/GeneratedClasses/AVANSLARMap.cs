using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class AVANSLARMap : ClassMap<AVANSLAR> {
        
        public AVANSLARMap() {
			Table("AVANSLAR");
			LazyLoad();
			Id(x => x.AV_ID).GeneratedBy.Assigned().Column("AV_ID");
			Map(x => x.KNR).Column("KNR").Not.Nullable().Length(6);
			Map(x => x.SNR).Column("SNR").Not.Nullable().Length(3);
			Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.TUTAR).Column("TUTAR").Not.Nullable();
			Map(x => x.KULLANILAN).Column("KULLANILAN").Not.Nullable();
			Map(x => x.IADEEDILEN).Column("IADEEDILEN").Not.Nullable();
			Map(x => x.ODEMESEKLI).Column("ODEMESEKLI").Not.Nullable().Length(1);
			Map(x => x.POSNO).Column("POSNO").Length(2);
			Map(x => x.MAKNO).Column("MAKNO").Not.Nullable().Length(7);
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
			Map(x => x.HESAPKODU).Column("HESAPKODU").Length(50);
			Map(x => x.ALTHESAPKODU).Column("ALTHESAPKODU").Length(50);
			Map(x => x.TIPI).Column("TIPI").Length(50);
			Map(x => x.AFATNO).Column("AFATNO").Length(50);
			Map(x => x.KALAN).Column("KALAN");
			Map(x => x.AMAKNO).Column("AMAKNO").Length(50);
        }
    }
}
