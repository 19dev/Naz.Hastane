using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class LOGHIZILDELETEDMap : ClassMap<LOGHIZILDELETED> {
        
        public LOGHIZILDELETEDMap() {
			Table("LOGHIZILDELETED");
			LazyLoad();
			CompositeId();
			Map(x => x.HD_ID).Column("HD_ID").Not.Nullable();
			Map(x => x.KNR).Column("KNR").Not.Nullable().Length(6);
			Map(x => x.SNR).Column("SNR").Not.Nullable().Length(3);
			Map(x => x.SIRANO).Column("SIRANO").Not.Nullable();
			Map(x => x.AKOD).Column("AKOD").Length(2);
			Map(x => x.TANIM).Column("TANIM").Not.Nullable().Length(2);
			Map(x => x.GRUP).Column("GRUP").Not.Nullable().Length(3);
			Map(x => x.CODE).Column("CODE").Not.Nullable().Length(15);
			Map(x => x.ARZT).Column("ARZT").Not.Nullable().Length(4);
			Map(x => x.ARZT2).Column("ARZT2").Not.Nullable().Length(4);
			Map(x => x.ADET).Column("ADET").Not.Nullable();
			Map(x => x.UNITE).Column("UNITE").Length(2);
			Map(x => x.NAME1).Column("NAME1").Not.Nullable().Length(100);
			Map(x => x.SATISF).Column("SATISF").Not.Nullable();
			Map(x => x.KSATISF).Column("KSATISF").Not.Nullable();
			Map(x => x.DSATISF).Column("DSATISF");
			Map(x => x.KDV).Column("KDV").Not.Nullable();
			Map(x => x.TARIH).Column("TARIH").Not.Nullable();
			Map(x => x.PSG).Column("PSG").Not.Nullable().Length(6);
			Map(x => x.HZLNO).Column("HZLNO");
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
			Map(x => x.MAKNO).Column("MAKNO").Length(8);
			Map(x => x.KFATNO).Column("KFATNO").Length(7);
			Map(x => x.FATURAEDILSIN).Column("FATURAEDILSIN").Length(1);
			Map(x => x.ISLENDIMI).Column("ISLENDIMI").Length(1);
			Map(x => x.PAKET).Column("PAKET").Length(1);
			Map(x => x.LRGOR).Column("LRGOR").Length(1);
			Map(x => x.BUTCODE).Column("BUTCODE").Length(20);
			Map(x => x.BUTNAME).Column("BUTNAME").Length(100);
			Map(x => x.ESKI_SATISF).Column("ESKI_SATISF");
			Map(x => x.KABUL).Column("KABUL").Length(1);
			Map(x => x.ISODENDI).Column("ISODENDI").Length(1);
			Map(x => x.CARIFIYAT).Column("CARIFIYAT");
			Map(x => x.ODEMETARIHI).Column("ODEMETARIHI");
			Map(x => x.ISDURUM).Column("ISDURUM").Length(1);
			Map(x => x.PSEANS).Column("PSEANS").Length(2);
			Map(x => x.SAGSOL).Column("SAGSOL").Length(1);
			Map(x => x.EUSCORE).Column("EUSCORE").Length(3);
			Map(x => x.HMAKNO).Column("HMAKNO").Length(12);
			Map(x => x.HODENDI).Column("HODENDI").Length(1);
			Map(x => x.AMAKNO).Column("AMAKNO").Length(12);
			Map(x => x.HYATISTARIHI).Column("HYATISTARIHI");
			Map(x => x.HCIKISTARIHI).Column("HCIKISTARIHI");
			Map(x => x.REFGUNSAY).Column("REFGUNSAY").Length(4);
			Map(x => x.ISLEMSIRANO).Column("ISLEMSIRANO").Length(20);
			Map(x => x.MEDSIRANO).Column("MEDSIRANO").Length(20);
			Map(x => x.MEDONAY).Column("MEDONAY").Length(2);
			Map(x => x.MEDTUTAR).Column("MEDTUTAR");
			Map(x => x.TBASLANGICSAATI).Column("TBASLANGICSAATI").Length(5);
			Map(x => x.TBITISSAATI).Column("TBITISSAATI").Length(5);
			Map(x => x.MEDOZDURUM).Column("MEDOZDURUM").Length(1);
			Map(x => x.MEDANOMALI).Column("MEDANOMALI").Length(1);
			Map(x => x.TG).Column("TG");
			Map(x => x.SAAT).Column("SAAT");
			Map(x => x.USER_ID_DELETED).Column("USER_ID_DELETED").Not.Nullable().Length(20);
			Map(x => x.DATE_DELETED).Column("DATE_DELETED").Not.Nullable();
        }
    }
}
