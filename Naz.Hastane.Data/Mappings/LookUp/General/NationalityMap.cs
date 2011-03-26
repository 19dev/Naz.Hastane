using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class NationalityMap : SubclassMap<Nationality>
    {
        public NationalityMap()
        {
            DiscriminatorValue("51");
        }
    }
}
