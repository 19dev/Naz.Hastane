using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class InsuranceCompanyContributionMap : ClassMap<InsuranceCompanyContribution>
    {
        public InsuranceCompanyContributionMap()
        {
            Table("KURADR_KATIL");

            Id(x => x.KNR).Column("KNR").Length(5);

            Map(x => x.ORAN1).Column("ORAN1").Length(150); //1
            Map(x => x.ORAN2).Column("ORAN2").Length(150); //1
        }
    }
}
