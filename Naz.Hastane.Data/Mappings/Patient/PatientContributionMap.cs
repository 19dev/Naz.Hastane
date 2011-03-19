using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientContributionMap : ClassMap<PatientContribution>
    {
        public PatientContributionMap()
        {
            Table("ADRES_KATIL");

            Id(x => x.PatientNo).Column("KNR").Length(6);

            Map(x => x.ORAN1).Column("ORAN1").Length(150); //1
            Map(x => x.ORAN2).Column("ORAN2").Length(150); //1

        }
    }
}
