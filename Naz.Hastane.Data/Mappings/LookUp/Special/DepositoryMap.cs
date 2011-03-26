using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class DepositoryMap : SubclassMap<Depository>
    {
        public DepositoryMap()
        {
            DiscriminatorValue(LookUpDiscriminators.Depository.GetDescription());
        }
    }
}
