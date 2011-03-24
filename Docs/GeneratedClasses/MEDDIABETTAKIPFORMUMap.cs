using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class MEDDIABETTAKIPFORMUMap : ClassMap<MEDDIABETTAKIPFORMU> {
        
        public MEDDIABETTAKIPFORMUMap() {
			Table("MEDDIABETTAKIPFORMU");
			LazyLoad();
			CompositeId();
			Map(x => x.KNR).Column("KNR").Length(6);
			Map(x => x.SNR).Column("SNR").Length(3);
			Map(x => x.TCKIMLIKNO).Column("TCKIMLIKNO").Length(11);
			Map(x => x.AD).Column("AD").Length(50);
			Map(x => x.SOYAD).Column("SOYAD").Length(50);
			Map(x => x.CEPTEL).Column("CEPTEL").Length(10);
			Map(x => x.PROTOKOLNO).Column("PROTOKOLNO").Length(20);
			Map(x => x.VIZITTARIHI).Column("VIZITTARIHI");
			Map(x => x.SAGLIKTESISKODU).Column("SAGLIKTESISKODU");
			Map(x => x.CINSIYET).Column("CINSIYET").Length(1);
			Map(x => x.IKAMETTURU).Column("IKAMETTURU");
			Map(x => x.ICD10TANI).Column("ICD10TANI").Length(10);
			Map(x => x.TANITARIHI).Column("TANITARIHI");
			Map(x => x.TIBBIBESLENMETEDAVISI).Column("TIBBIBESLENMETEDAVISI");
			Map(x => x.EGZERSIZ).Column("EGZERSIZ");
			Map(x => x.BASVURUNEDENI).Column("BASVURUNEDENI");
			Map(x => x.GLUKOMETRE).Column("GLUKOMETRE").Length(1);
			Map(x => x.KANSEKERITAKIPSAYISI).Column("KANSEKERITAKIPSAYISI");
			Map(x => x.SISTOLIKKANBASINICI).Column("SISTOLIKKANBASINICI");
			Map(x => x.DIYOSTOLIKKANBASINCI).Column("DIYOSTOLIKKANBASINCI");
			Map(x => x.BOY).Column("BOY").Length(10);
			Map(x => x.KILO).Column("KILO").Length(10);
			Map(x => x.VKI).Column("VKI").Length(10);
			Map(x => x.APG).Column("APG").Length(10);
			Map(x => x.TPG).Column("TPG").Length(10);
			Map(x => x.HBA1C).Column("HBA1C").Length(10);
			Map(x => x.KREATININ).Column("KREATININ").Length(10);
			Map(x => x.TRIGLISERID).Column("TRIGLISERID").Length(10);
			Map(x => x.LDLKKOL).Column("LDLKKOL").Length(10);
			Map(x => x.HDLKOL).Column("HDLKOL").Length(10);
			Map(x => x.ALT).Column("ALT").Length(10);
			Map(x => x.ANTIGAD).Column("ANTIGAD").Length(1);
			Map(x => x.EKG).Column("EKG");
			Map(x => x.MIKROALBUMINURI).Column("MIKROALBUMINURI").Length(1);
			Map(x => x.GOZMUAYENE).Column("GOZMUAYENE");
			Map(x => x.PERIFERIKSENSORYAL).Column("PERIFERIKSENSORYAL").Length(1);
			Map(x => x.KRONERARTER).Column("KRONERARTER").Length(1);
			Map(x => x.SEREBOVASKULERH).Column("SEREBOVASKULERH").Length(1);
			Map(x => x.AYAKMUAYENSI).Column("AYAKMUAYENSI").Length(1);
			Map(x => x.AKUTKOMLIKASYON).Column("AKUTKOMLIKASYON");
			Map(x => x.YATISGUN).Column("YATISGUN");
			Map(x => x.INSULINPOMPASI).Column("INSULINPOMPASI").Length(1);
			Map(x => x.INSULINPOMPASIVERTARIH).Column("INSULINPOMPASIVERTARIH");
			Map(x => x.INSULINPOMPDEGTARIH).Column("INSULINPOMPDEGTARIH");
			Map(x => x.BIREYSELEGITIMSAYISI).Column("BIREYSELEGITIMSAYISI");
			Map(x => x.GRUPEGITIMSAYISI).Column("GRUPEGITIMSAYISI");
			Map(x => x.EGITIMDM).Column("EGITIMDM").Length(1);
			Map(x => x.GONDERILDI).Column("GONDERILDI").Not.Nullable().Length(1);
			Map(x => x.TAKIPFORMUNO).Column("TAKIPFORMUNO").Length(10);
        }
    }
}
