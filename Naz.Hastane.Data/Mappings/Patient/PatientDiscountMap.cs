using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientDiscountMap : ClassMap<PatientDiscount>
    {
        public PatientDiscountMap()
        {
            Table("HASTAINDIRIMLER");

            Id(x => x.HI_ID).Column("HI_ID");

            Map(x => x.ARZT).Column("ARZT").Length(4); //0
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.HASTATOPLAM).Column("HASTATOPLAM").Length(8); //0
            Map(x => x.INDIRIMACIKLAMA).Column("INDIRIMACIKLAMA").Length(100); //1
            Map(x => x.INDIRIMNEDEN).Column("INDIRIMNEDEN").Length(4); //0
            Map(x => x.INDIRIMTOPLAM).Column("INDIRIMTOPLAM").Length(8); //0
            Map(x => x.INDIRIMYUZDE).Column("INDIRIMYUZDE").Length(8); //0
            Map(x => x.KNR).Column("KNR").Length(6); //0
            Map(x => x.MAKNO).Column("MAKNO").Length(8); //1
            Map(x => x.SECILITOPLAM).Column("SECILITOPLAM").Length(8); //0
            Map(x => x.SNR).Column("SNR").Length(3); //0
            Map(x => x.SONTOPLAM).Column("SONTOPLAM").Length(8); //0
            Map(x => x.TARIH).Column("TARIH").Length(4); //0
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
        }
    }
}
