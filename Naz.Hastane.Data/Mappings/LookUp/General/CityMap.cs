using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.LookUp.General;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class CityMap : SubclassMap<City>
    {
        public CityMap()
        {
            DiscriminatorValue(LookUpDiscriminators.City.GetDescription());
        }
    }
}
