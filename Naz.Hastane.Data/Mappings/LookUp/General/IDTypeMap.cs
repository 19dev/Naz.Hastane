using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class IDTypeMap : ClassMap<IDType>
    {
        public IDTypeMap()
        {
            Table("tlkpIDType");

            Id(x => x.ID);
            Map(x => x.Value).Length(50);
            Map(x => x.Code).Length(255);
        }
    }
}
