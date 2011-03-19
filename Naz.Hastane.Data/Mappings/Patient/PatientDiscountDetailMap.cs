using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientDiscountDetailMap : ClassMap<PatientDiscountDetail>
    {
        public PatientDiscountDetailMap()
        {
            Table("HASTAINDIRIMLER_DETAY");

            Id(x => x.HI_DET_ID).Column("HI_DET_ID");

            Map(x => x.ESATISF).Column("ESATISF").Length(8); //0
            Map(x => x.HI_ID).Column("HI_ID").Length(4); //0
            Map(x => x.KNR).Column("KNR").Length(6); //0
            Map(x => x.SIRANO).Column("SIRANO").Length(8); //0
            Map(x => x.SNR).Column("SNR").Length(3); //0
            Map(x => x.YSATISF).Column("YSATISF").Length(8); //0
        }
    }
}
