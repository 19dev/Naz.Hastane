using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.LookUp.General;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class CityMap : SubclassMap<City>
    {
        public CityMap()
        {
            DiscriminatorValue("37");
        }
    }
}
