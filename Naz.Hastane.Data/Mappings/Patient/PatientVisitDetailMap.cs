using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientVisitDetailMap : ClassMap<PatientVisitDetail>
    {
        public PatientVisitDetailMap()
        {
            Table("HIZIL");

            CompositeId()
                .KeyReference(x => x.PatientVisit, "KNR", "SNR")
                //.KeyProperty(x => x.KNR, "KNR")
                //.KeyProperty(x => x.SNR,  "SNR")
                .KeyProperty(x => x.DetailNo, "SIRANO");

            Map(x => x.AKOD).Column("AKOD");
            Map(x => x.TANIM).Column("TANIM");
            Map(x => x.GRUP).Column("GRUP");
            Map(x => x.CODE).Column("CODE");

            Map(x => x.NAME1).Column("NAME1");
            Map(x => x.ADET).Column("ADET");
            Map(x => x.UNITE).Column("UNITE");
            Map(x => x.SATISF).Column("SATISF");
            Map(x => x.KSATISF).Column("KSATISF");
            Map(x => x.DSATISF).Column("DSATISF");
            Map(x => x.KDV).Column("KDV");
            Map(x => x.TARIH).Column("TARIH");

            Map(x => x.Doctor).Column("ARZT");
            Map(x => x.Doctor2).Column("ARZT2");

            Map(x => x.PSG).Column("PSG");
            Map(x => x.HZLNO).Column("HZLNO");
            Map(x => x.MAKNO).Column("MAKNO");
            Map(x => x.KFATNO).Column("KFATNO");
            Map(x => x.FATURAEDILSIN).Column("FATURAEDILSIN");
            Map(x => x.ISLENDIMI).Column("ISLENDIMI");
            Map(x => x.PAKET).Column("PAKET");
            Map(x => x.LRGOR).Column("LRGOR");
            Map(x => x.BUTCODE).Column("BUTCODE");
            Map(x => x.BUTNAME).Column("BUTNAME");
            Map(x => x.ESKI_SATISF).Column("ESKI_SATISF");
            Map(x => x.KABUL).Column("KABUL");
            Map(x => x.ISODENDI).Column("ISODENDI");
            Map(x => x.CARIFIYAT).Column("CARIFIYAT");
            Map(x => x.ODEMETARIHI).Column("ODEMETARIHI");
            Map(x => x.ISDURUM).Column("ISDURUM");
            Map(x => x.PSEANS).Column("PSEANS");
            Map(x => x.SAGSOL).Column("SAGSOL");
            Map(x => x.EUSCORE).Column("EUSCORE");
            Map(x => x.HMAKNO).Column("HMAKNO");
            Map(x => x.HODENDI).Column("HODENDI");
            Map(x => x.AMAKNO).Column("AMAKNO");
            Map(x => x.HYATISTARIHI).Column("HYATISTARIHI");
            Map(x => x.HCIKISTARIHI).Column("HCIKISTARIHI");
            Map(x => x.REFGUNSAY).Column("REFGUNSAY");
            Map(x => x.ISLEMSIRANO).Column("ISLEMSIRANO");
            Map(x => x.MEDSIRANO).Column("MEDSIRANO");
            Map(x => x.MEDONAY).Column("MEDONAY");
            Map(x => x.MEDTUTAR).Column("MEDTUTAR");
            Map(x => x.TBASLANGICSAATI).Column("TBASLANGICSAATI");
            Map(x => x.TBITISSAATI).Column("TBITISSAATI");
            Map(x => x.MEDOZDURUM).Column("MEDOZDURUM");
            Map(x => x.MEDANOMALI).Column("MEDANOMALI");
            Map(x => x.TG).Column("TG");

            Map(x => x.USER_ID).Column("USER_ID");
            Map(x => x.DATE_CREATE).Column("DATE_CREATE");
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE");
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");
        }
    }
}
