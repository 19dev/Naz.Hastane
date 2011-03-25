using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class EKGMap : ClassMap<EKG>
    {
        public EKGMap()
        {
            Table("tlkpMedulaDiabetEKG");

            Id(x => x.ID);
            Map(x => x.Value).Length(255);
        }
    }
}
