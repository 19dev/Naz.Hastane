using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class LBISTEMap : ClassMap<LBISTE> {
        
        public LBISTEMap() {
			Table("LBISTE");
			LazyLoad();
			CompositeId().KeyProperty(x => x.TANIM).KeyProperty(x => x.GRUP).KeyProperty(x => x.CODE).KeyProperty(x => x.KNR).KeyProperty(x => x.SNR).KeyProperty(x => x.TARIH);
			Map(x => x.TOOLTIPTEXT).Column("TOOLTIPTEXT").Length(75);
			Map(x => x.KABUL).Column("KABUL").Not.Nullable().Length(1);
			Map(x => x.KABUL_ID).Column("KABUL_ID").Length(20);
			Map(x => x.KABUL_TARIH).Column("KABUL_TARIH");
			Map(x => x.KABUL_NO).Column("KABUL_NO").Length(10);
			Map(x => x.DISMERKEZ).Column("DISMERKEZ").Length(5);
			Map(x => x.ONAY).Column("ONAY").Not.Nullable().Length(1);
			Map(x => x.ONAY_ID).Column("ONAY_ID").Length(20);
			Map(x => x.ONAY_TARIH).Column("ONAY_TARIH");
			Map(x => x.DRONAY).Column("DRONAY").Not.Nullable().Length(1);
			Map(x => x.DRONAY_ID).Column("DRONAY_ID").Length(20);
			Map(x => x.DRONAY_TARIH).Column("DRONAY_TARIH");
			Map(x => x.YAZILDIMI).Column("YAZILDIMI").Length(1);
			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
			Map(x => x.ORNEK_TARIHI).Column("ORNEK_TARIHI");
			HasMany(x => x.LABORSONUCS);
			HasMany(x => x.LABORSONUCS);
			HasMany(x => x.LABORSONUCS);
			HasMany(x => x.LABORSONUCS);
			HasMany(x => x.LABORSONUCS);
			HasMany(x => x.LABORSONUCS);
			HasMany(x => x.LABORTEXTS);
			HasMany(x => x.LABORTEXTS);
			HasMany(x => x.LABORTEXTS);
			HasMany(x => x.LABORTEXTS);
			HasMany(x => x.LABORTEXTS);
			HasMany(x => x.LABORTEXTS);
        }
    }
}
