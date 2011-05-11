using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class LOGHIZILDOKTORDEGISTIMap : ClassMap<LOGHIZILDOKTORDEGISTI> {
        
        public LOGHIZILDOKTORDEGISTIMap() {
			Table("LOGHIZILDOKTORDEGISTI");
			LazyLoad();
			CompositeId();
			Map(x => x.KNR).Column("KNR").Not.Nullable().Length(6);
			Map(x => x.SNR).Column("SNR").Not.Nullable().Length(3);
			Map(x => x.SIRANO).Column("SIRANO").Not.Nullable();
			Map(x => x.AKOD).Column("AKOD").Length(2);
			Map(x => x.TANIM).Column("TANIM").Not.Nullable().Length(2);
			Map(x => x.GRUP).Column("GRUP").Not.Nullable().Length(3);
			Map(x => x.CODE).Column("CODE").Not.Nullable().Length(15);
			Map(x => x.EARZT).Column("EARZT").Not.Nullable().Length(4);
			Map(x => x.YARZT).Column("YARZT").Length(4);
			Map(x => x.EARZT2).Column("EARZT2").Not.Nullable().Length(4);
			Map(x => x.YARZT2).Column("YARZT2").Length(4);
			Map(x => x.EADET).Column("EADET").Not.Nullable();
			Map(x => x.YADET).Column("YADET");
			Map(x => x.ESATISF).Column("ESATISF").Not.Nullable();
			Map(x => x.YSATISF).Column("YSATISF").Not.Nullable();
			Map(x => x.EKSATISF).Column("EKSATISF").Not.Nullable();
			Map(x => x.YKSATISF).Column("YKSATISF");
			Map(x => x.ETARIH).Column("ETARIH").Not.Nullable();
			Map(x => x.YTARIH).Column("YTARIH");
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
        }
    }
}
