using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class WarehouseMap : SubclassMap<Warehouse>
    {
        public WarehouseMap()
        {
            DiscriminatorValue("04");
        }
    }
}
