using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class TET_ANAMNEZMap : ClassMap<TET_ANAMNEZ> {
        
        public TET_ANAMNEZMap() {
			Table("TET_ANAMNEZ");
			LazyLoad();
			CompositeId().KeyProperty(x => x.KNR).KeyProperty(x => x.SNR).KeyProperty(x => x.GELIS_TARIHI);
			Map(x => x.OZSOYGECMIS).Column("OZSOYGECMIS").Length(2147483647);
			Map(x => x.SISTEMSORGULARI).Column("SISTEMSORGULARI").Length(2147483647);
			Map(x => x.MUAYENEBULGULARI).Column("MUAYENEBULGULARI").Length(2147483647);
			Map(x => x.ONTANI).Column("ONTANI").Length(100);
			Map(x => x.TESHISVETEDAVI).Column("TESHISVETEDAVI").Length(2147483647);
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
			Map(x => x.DOKTOR).Column("DOKTOR").Length(4);
			Map(x => x.SERVIS).Column("SERVIS").Length(2);
			Map(x => x.PROTNO).Column("PROTNO").Length(20);
			Map(x => x.OYKU).Column("OYKU").Length(1000);
			Map(x => x.YAKINMA).Column("YAKINMA").Length(2147483647);
			Map(x => x.NOTLAR).Column("NOTLAR").Length(50);
			Map(x => x.MUAYENE_TARIHI).Column("MUAYENE_TARIHI");
        }
    }
}
