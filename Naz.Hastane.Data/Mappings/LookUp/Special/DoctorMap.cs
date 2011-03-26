using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class DoctorMap : SubclassMap<Doctor>
    {
        public DoctorMap()
        {
            DiscriminatorValue("07" );

            References(x => x.Service).Column("SLXX");
            Map(x => x.QueueNo).Column("SLX");
        }
    }
}
