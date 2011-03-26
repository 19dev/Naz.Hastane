using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class VATMap : SubclassMap<VAT>
    {
        public VATMap()
        {
            DiscriminatorValue("02");
        }
    }
}
