using System;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class IDTypeMap : ClassMap<IDType>
    {
        public IDTypeMap()
        {
            Table("tlkpIDType");

            Id(x => x.ID);
            Map(x => x.Value).Length(50);
        }
    }
}
