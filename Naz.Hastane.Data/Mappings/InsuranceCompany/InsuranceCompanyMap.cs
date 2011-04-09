using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class InsuranceCompanyMap : ClassMap<InsuranceCompany>
    {
        public InsuranceCompanyMap()
        {
            Table("KURADR");

            Id(x => x.Name).Column("PSG").Length(6);

            Map(x => x.ACILKATILIM).Column("ACILKATILIM").Length(1); //0
            Map(x => x.ADI1).Column("ADI1").Length(200); //0
            Map(x => x.ADRZUS).Column("ADRZUS").Length(200); //1
            Map(x => x.ALACAK).Column("ALACAK").Length(8); //0
            Map(x => x.ANLASMADURUMU).Column("ANLASMADURUMU").Length(1); //0
            Map(x => x.BORC).Column("BORC").Length(8); //0
            Map(x => x.c_alacak).Column("c_alacak").Length(8); //1
            Map(x => x.c_borc).Column("c_borc").Length(8); //1
            Map(x => x.c_hesap_kodu).Column("c_hesap_kodu").Length(20); //1
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.DESTEKPSG).Column("DESTEKPSG").Length(6); //1
            Map(x => x.DRPAYNEZAMAN).Column("DRPAYNEZAMAN").Length(1); //0
            Map(x => x.DSTKDUS).Column("DSTKDUS").Length(1); //1
            Map(x => x.ECZBILGKATPAYI).Column("ECZBILGKATPAYI").Length(8); //0
            Map(x => x.ECZKATPAYI).Column("ECZKATPAYI").Length(8); //0
            Map(x => x.ECZMUAUCRETI).Column("ECZMUAUCRETI").Length(8); //0
            Map(x => x.EKSIKODENEN).Column("EKSIKODENEN").Length(8); //0
            Map(x => x.EPOSTA).Column("EPOSTA").Length(50); //1
            Map(x => x.FAX).Column("FAX").Length(20); //1
            Map(x => x.FIXKURUM).Column("FIXKURUM").Length(2); //0
            Map(x => x.FIYLIST).Column("FIYLIST").Length(2); //1
            Map(x => x.HASTAKATILIM).Column("HASTAKATILIM").Length(1); //0
            Map(x => x.HASTALIMIT).Column("HASTALIMIT").Length(8); //0
            Map(x => x.hesap_kodu).Column("hesap_kodu").Length(100); //1
            Map(x => x.ILACINDIRIM).Column("ILACINDIRIM").Length(1); //1
            Map(x => x.ILACODE).Column("ILACODE").Length(1); //0
            Map(x => x.KNR).Column("KNR").Length(5); //0
            Map(x => x.KURUMTIPI).Column("KURUMTIPI").Length(4); //0
            Map(x => x.lngKurumTipiID).Column("lngKurumTipiID").Length(4); //1
            Map(x => x.MKURUM).Column("MKURUM").Length(50); //1
            Map(x => x.MLIMIT).Column("MLIMIT").Length(50); //1
            Map(x => x.ORAN1).Column("ORAN1").Length(150); //0
            Map(x => x.ORAN2).Column("ORAN2").Length(150); //0
            Map(x => x.ORKA1).Column("ORKA1").Length(10); //1
            Map(x => x.ORKA2).Column("ORKA2").Length(10); //1
            Map(x => x.ORKA3).Column("ORKA3").Length(10); //1
            Map(x => x.ORT).Column("ORT").Length(20); //0
            Map(x => x.OZELNOT).Column("OZELNOT").Length(16); //1
            Map(x => x.PFIYLIST).Column("PFIYLIST").Length(2); //0
            Map(x => x.PLZ).Column("PLZ").Length(5); //1
            Map(x => x.POLSURE).Column("POLSURE").Length(50); //1
            Map(x => x.SARFODE).Column("SARFODE").Length(1); //0
            Map(x => x.SEVKBASAMAK).Column("SEVKBASAMAK").Length(1); //1
            Map(x => x.SEVKGECSURE).Column("SEVKGECSURE").Length(2); //0
            Map(x => x.SIFIRGOSTER).Column("SIFIRGOSTER").Length(50); //0
            Map(x => x.SIRAID).Column("SIRAID").Length(8); //0
            Map(x => x.STR).Column("STR").Length(30); //1
            Map(x => x.TEL1).Column("TEL1").Length(20); //1
            Map(x => x.TEL2).Column("TEL2").Length(20); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1
            Map(x => x.VADESURESI).Column("VADESURESI").Length(50); //1
            Map(x => x.VER).Column("VER").Length(20); //1
            Map(x => x.VERDAR).Column("VERDAR").Length(20); //1
            Map(x => x.VERNO).Column("VERNO").Length(20); //1
            Map(x => x.YETKILI).Column("YETKILI").Length(28); //1
            Map(x => x.YFIYLIST).Column("YFIYLIST").Length(2); //1
        }
    }
}
