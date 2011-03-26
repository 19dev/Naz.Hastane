using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class VATMap : SubclassMap<VAT>
    {
        public VATMap()
        {
            DiscriminatorValue(LookUpDiscriminators.VAT.GetDescription());
        }
    }
}
