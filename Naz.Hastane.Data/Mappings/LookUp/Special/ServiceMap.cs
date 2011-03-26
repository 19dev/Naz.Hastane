using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class ServiceMap : SubclassMap<Service>
    {
        public ServiceMap()
        {
            DiscriminatorValue(LookUpDiscriminators.Service.GetDescription());

            Map(x => x.SorguTuru).Column("SLY");
            Map(x => x.Type).Column("SLXX");
            Map(x => x.BranchCode).Column("SLXA");
            Map(x => x.TreatmentType).Column("SLYA");

            HasMany(x => x.SGKAutoExaminations)
                .KeyColumn("SERVISKODU")
                .Inverse()
                .Not.LazyLoad();
        }
    }
}
