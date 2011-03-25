using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class HabitCodeMap : ClassMap<HabitCode>
    {
        public HabitCodeMap()
        {
            Table("tlkpMedulaDiabetHabitCode");

            Id(x => x.ID);
            Map(x => x.Value).Length(255);
        }
    }
}
