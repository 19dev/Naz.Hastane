using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class StockMap : ClassMap<Stock> {
        
        public StockMap() {
			Table("Stock");
			LazyLoad();
			CompositeId().KeyProperty(x => x.AKOD).KeyProperty(x => x.TANIM).KeyProperty(x => x.GRUP).KeyProperty(x => x.CODE);
			Map(x => x.NAME1).Column("NAME1").Not.Nullable().Length(65);
			Map(x => x.NAME2).Column("NAME2").Length(35);
			Map(x => x.UNITE).Column("UNITE").Length(4);
			Map(x => x.FIRMA).Column("FIRMA").Length(4);
			Map(x => x.KDV).Column("KDV").Not.Nullable();
			Map(x => x.SATISF).Column("SATISF").Not.Nullable();
			Map(x => x.ALISF).Column("ALISF").Not.Nullable();
			Map(x => x.KSATISF).Column("KSATISF");
			Map(x => x.ASATISF).Column("ASATISF");
			Map(x => x.YSATISF).Column("YSATISF");
			Map(x => x.ORTALAMAF).Column("ORTALAMAF").Not.Nullable();
			Map(x => x.TOPGIR).Column("TOPGIR").Not.Nullable();
			Map(x => x.TOPCIK).Column("TOPCIK").Not.Nullable();
			Map(x => x.MINIMUM).Column("MINIMUM").Not.Nullable();
			Map(x => x.VERADET).Column("VERADET").Not.Nullable();
			Map(x => x.TOPSAT).Column("TOPSAT").Not.Nullable();
			Map(x => x.TOPALS).Column("TOPALS").Not.Nullable();
			Map(x => x.SEVKDAT).Column("SEVKDAT");
			Map(x => x.ENVDAT).Column("ENVDAT");
			Map(x => x.DEVIR).Column("DEVIR").Not.Nullable();
			Map(x => x.SKDAT).Column("SKDAT");
			Map(x => x.FAR_KOD).Column("FAR_KOD").Length(4);
			Map(x => x.JEN_KOD).Column("JEN_KOD").Length(4);
			Map(x => x.DOZAJ).Column("DOZAJ").Not.Nullable();
			Map(x => x.KAR).Column("KAR").Not.Nullable();
			Map(x => x.DOVIZ).Column("DOVIZ");
			Map(x => x.DOVIZCINSI).Column("DOVIZCINSI").Length(3);
			Map(x => x.REUSE).Column("REUSE").Not.Nullable().Length(1);
			Map(x => x.INFIYAT).Column("INFIYAT").Not.Nullable();
			Map(x => x.KOLI).Column("KOLI").Not.Nullable();
			Map(x => x.DAHHAR).Column("DAHHAR").Not.Nullable().Length(1);
			Map(x => x.OZELF).Column("OZELF").Not.Nullable().Length(1);
			Map(x => x.GUNLUK).Column("GUNLUK").Not.Nullable();
			Map(x => x.ILACKONTROL).Column("ILACKONTROL").Not.Nullable().Length(1);
			Map(x => x.ILACKONTROLSURE).Column("ILACKONTROLSURE").Not.Nullable();
			Map(x => x.KURUMINDIRIM).Column("KURUMINDIRIM");
			Map(x => x.ESKIALISF).Column("ESKIALISF");
			Map(x => x.APILACSARF).Column("APILACSARF").Length(1);
			Map(x => x.PDAHIL).Column("PDAHIL").Length(1);
			Map(x => x.MALTURU).Column("MALTURU").Length(4);
			Map(x => x.DETAYKOD).Column("DETAYKOD").Length(50);
			Map(x => x.mk).Column("mk");
			Map(x => x.SEC).Column("SEC");
			Map(x => x.ILACADET).Column("ILACADET").Length(10);
			Map(x => x.MEDGONDER).Column("MEDGONDER").Length(1);
			Map(x => x.MALDURUM).Column("MALDURUM").Length(10);
			Map(x => x.ILACTURU).Column("ILACTURU").Length(1);
			Map(x => x.KBIRIMI).Column("KBIRIMI");
			Map(x => x.JENKOD).Column("JENKOD").Length(50);
			Map(x => x.ETKENMADDE).Column("ETKENMADDE").Length(250);
			Map(x => x.BIRIMCINS).Column("BIRIMCINS").Length(50);
			Map(x => x.RECTIPI).Column("RECTIPI").Length(50);
			Map(x => x.ILFIRMA).Column("ILFIRMA").Length(50);
			Map(x => x.UBBCODE).Column("UBBCODE").Length(50);
			Map(x => x.KATKIPAYI).Column("KATKIPAYI").Length(1);
			Map(x => x.MEDONAY).Column("MEDONAY").Length(1);
			Map(x => x.MAKSIMUM).Column("MAKSIMUM").Length(10);
			Map(x => x.KHIZMET).Column("KHIZMET").Not.Nullable().Length(1);
			Map(x => x.KONTROLKODU).Column("KONTROLKODU").Length(35);
			Map(x => x.KRITIKMIKTAR).Column("KRITIKMIKTAR");
        }
    }
}
