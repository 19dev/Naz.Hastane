using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class WarehouseMap : SubclassMap<Warehouse>
    {
        public WarehouseMap()
        {
            //DiscriminatorValue(Utilities.GetDescription<LookUpDiscriminators>(LookUpDiscriminators.Warehouse));
            DiscriminatorValue(LookUpDiscriminators.Warehouse.GetDescription());
        }
    }
}
