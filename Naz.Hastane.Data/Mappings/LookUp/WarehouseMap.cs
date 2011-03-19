using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public class WarehouseMap : SubclassMap<Warehouse>
    {
        public WarehouseMap()
        {
            DiscriminatorValue("04");
        }
    }
}
