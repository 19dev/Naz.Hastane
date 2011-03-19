using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class InsuranceCompanyDiscountMap : ClassMap<InsuranceCompanyDiscount>
    {
        public InsuranceCompanyDiscountMap()
        {
            Table("KURUMINDIRIMORANLARI");

            CompositeId()
                .KeyProperty(x => x.KNR, "KNR") //.Length(50); //0
                .KeyProperty(x => x.TANIM, "TANIM") //.Length(50); //0
                .KeyProperty(x => x.GRUP, "GRUP"); //.Length(50); //0

            Map(x => x.INDIRIMORANI).Column("INDIRIMORANI").Length(8); //0
        }
    }
}
