using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class DoctorMap : SubclassMap<Doctor>
    {
        public DoctorMap()
        {
            DiscriminatorValue(LookUpDiscriminators.Doctor.GetDescription());

            References(x => x.Service).Column("SLXX");
            Map(x => x.QueueNo).Column("SLX");
        }
    }
}
