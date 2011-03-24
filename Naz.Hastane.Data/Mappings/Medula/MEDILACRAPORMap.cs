using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{

    public class MEDILACRAPORMap : ClassMap<MEDILACRAPOR>
    {

        public MEDILACRAPORMap()
        {

            Table("MEDILACRAPOR");

            CompositeId().KeyReference(x => x.PatientVisit, "KNR", "SNR");

            Map(x => x.RAPORNO).Column("RAPORNO").Length(20);
            Map(x => x.RAPORTARIHI).Column("RAPORTARIHI");
            Map(x => x.RAPORTURU).Column("RAPORTURU").Length(50);
            Map(x => x.RAPORBASTARIH).Column("RAPORBASTARIH");
            Map(x => x.RAPORBITTARIH).Column("RAPORBITTARIH");
            Map(x => x.RAPORDTUR).Column("RAPORDTUR").Length(50);
            Map(x => x.RAPPROTNO).Column("RAPPROTNO").Length(20);
            Map(x => x.RAPPROTTARIH).Column("RAPPROTTARIH");
            Map(x => x.RAPDURUM).Column("RAPDURUM").Length(50);
            Map(x => x.RAPACIKLAMA).Column("RAPACIKLAMA").Length(1000);
            Map(x => x.RAPKTANI).Column("RAPKTANI").Length(255);
            Map(x => x.HSTTAKIPNO).Column("HSTTAKIPNO").Length(50);
            Map(x => x.HSTTCNO).Column("HSTTCNO").Length(50);
            Map(x => x.HSTSNO).Column("HSTSNO").Length(50);
            Map(x => x.HSTKNO).Column("HSTKNO").Length(50);
            Map(x => x.HSTYKODU).Column("HSTYKODU").Length(50);
            Map(x => x.HSTPTIPI).Column("HSTPTIPI").Length(50);
            Map(x => x.HSTPTARIH).Column("HSTPTARIH");
            Map(x => x.HSTDEVKURUM).Column("HSTDEVKURUM").Length(50);
            Map(x => x.HSTSGTURU).Column("HSTSGTURU").Length(50);
            Map(x => x.DRTESNO).Column("DRTESNO").Length(50);
            Map(x => x.DRADI).Column("DRADI").Length(50);
            Map(x => x.DRSOYADI).Column("DRSOYADI").Length(50);
            Map(x => x.DRBRANSKODU).Column("DRBRANSKODU").Length(10);
            Map(x => x.DRTIPI).Column("DRTIPI").Length(50);
            Map(x => x.DRTANIKODU).Column("DRTANIKODU").Length(50);
            Map(x => x.HASTAADI).Column("HASTAADI").Length(50);
            Map(x => x.HASTASOYADI).Column("HASTASOYADI").Length(50);
            Map(x => x.RAPTESBASTARIH).Column("RAPTESBASTARIH");
            Map(x => x.RAPTESBITTARIH).Column("RAPTESBITTARIH");
            Map(x => x.RAPTESKODU).Column("RAPTESKODU").Length(50);
            Map(x => x.TAKIPNO).Column("TAKIPNO").Length(50);
            Map(x => x.RAPGONDERILDI).Column("RAPGONDERILDI").Length(50);
            Map(x => x.RAPTAKIPNO).Column("RAPTAKIPNO").Length(20);
            Map(x => x.RAPTURU).Column("RAPTURU").Length(50);
            Map(x => x.RAPTEDAVITURU).Column("RAPTEDAVITURU").Length(10);
            Map(x => x.ESWTVBKODU).Column("ESWTVBKODU").Length(10);
            Map(x => x.ESWTSGUN).Column("ESWTSGUN").Length(10);
            Map(x => x.ESWTSSAY).Column("ESWTSSAY").Length(10);
            Map(x => x.ESWTBUTKODU).Column("ESWTBUTKODU").Length(10);
            Map(x => x.FTRVBKODU).Column("FTRVBKODU").Length(10);
            Map(x => x.FTRSGUN).Column("FTRSGUN").Length(10);
            Map(x => x.FTRSSAY).Column("FTRSSAY").Length(10);
            Map(x => x.FTRBUTKODU).Column("FTRBUTKODU").Length(10);
            Map(x => x.ESWLBUTKODU).Column("ESWLBUTKODU").Length(10);
            Map(x => x.ESWLTASSAYI).Column("ESWLTASSAYI").Length(10);
            Map(x => x.ESWLSSAY).Column("ESWLSSAY").Length(10);
            Map(x => x.ESWLBBILG).Column("ESWLBBILG").Length(10);
            Map(x => x.TAKIPFORMUNO).Column("TAKIPFORMUNO").Length(10);
        }
    }
}
