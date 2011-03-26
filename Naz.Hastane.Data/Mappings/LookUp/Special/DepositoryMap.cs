using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class DepositoryMap : SubclassMap<Depository>
    {
        public DepositoryMap()
        {
            DiscriminatorValue("03");
        }
    }
}
