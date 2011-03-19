using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class InsuranceCompanyDetailMap : ClassMap<InsuranceCompanyDetail>
    {
        public InsuranceCompanyDetailMap()
        {
            Table("KURHIZIL");

            CompositeId()
                .KeyProperty(x => x.KKNR, "KKNR")  //.Length(6) //0
                .KeyProperty(x => x.KNR, "KNR") //.Length(6); //0
                .KeyProperty(x => x.SNR, "SNR") //.Length(3); //0
                .KeyProperty(x => x.SIRANO, "SIRANO"); //.Length(8); //0
                
            Map(x => x.ADET).Column("ADET").Length(8); //0
            Map(x => x.AKOD).Column("AKOD").Length(2); //1
            Map(x => x.ARZT).Column("ARZT").Length(4); //0
            Map(x => x.ARZT2).Column("ARZT2").Length(4); //0
            Map(x => x.CODE).Column("CODE").Length(15); //0
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.GRUP).Column("GRUP").Length(3); //0
            Map(x => x.HZLNO).Column("HZLNO").Length(2); //1
            Map(x => x.ISLENDIMI).Column("ISLENDIMI").Length(2); //1
            Map(x => x.KDV).Column("KDV").Length(8); //0
            Map(x => x.KFATNO).Column("KFATNO").Length(7); //1
            Map(x => x.KSATISF).Column("KSATISF").Length(8); //0
            Map(x => x.MAKNO).Column("MAKNO").Length(8); //1
            Map(x => x.NAME1).Column("NAME1").Length(100); //0
            Map(x => x.PAKET).Column("PAKET").Length(2); //1
            Map(x => x.PSG).Column("PSG").Length(6); //0
            Map(x => x.SATISF).Column("SATISF").Length(8); //0
            Map(x => x.TANIM).Column("TANIM").Length(2); //0
            Map(x => x.TARIH).Column("TARIH").Length(8); //0
            Map(x => x.UNITE).Column("UNITE").Length(2); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1

        }
    }
}
