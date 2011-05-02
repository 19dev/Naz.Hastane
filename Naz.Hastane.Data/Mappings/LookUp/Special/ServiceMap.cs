using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class ServiceMap : ClassMap<Service>
    {
        public ServiceMap()
        {
            Table("tlkpvService");

            Id(x => x.Code).Column("SLB").Length(10);

            Map(x => x.ID0).Column("SLK").Length(2);
            Map(x => x.Value).Column("SLT").Length(150);

            Map(x => x.SorguTuru).Column("SLY");
            Map(x => x.Type).Column("SLXX");
            Map(x => x.BranchCode).Column("SLXA");
            Map(x => x.TreatmentType).Column("SLYA");

            HasMany(x => x.SGKAutoExaminations)
                .KeyColumn("SERVISKODU")
                .Inverse();
                //.Not.LazyLoad();
            HasMany(x => x.SGKAutoExaminationSameDays)
                .KeyColumn("SERVISKODU")
                .Inverse();
                //.Not.LazyLoad();
        }
    }
}
