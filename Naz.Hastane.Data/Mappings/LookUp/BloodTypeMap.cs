using System;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class BloodTypeMap : ClassMap<BloodType>
    {
        public BloodTypeMap()
        {
            Table("tlkpBloodType");

            Id(x => x.ID);
            Map(x => x.Value).Length(50);
            Map(x => x.Code);
        }
    }
}
