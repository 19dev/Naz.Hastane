using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class TBTMap : ClassMap<TBT>
    {
        public TBTMap()
        {
            Table("tlkpMedulaDiabetTBT");

            Id(x => x.ID);
            Map(x => x.Value).Length(255);
        }
    }
}
