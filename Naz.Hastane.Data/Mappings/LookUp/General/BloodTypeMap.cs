using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.LookUp.General;

namespace Naz.Hastane.Data.Mappings.LookUp.General
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
