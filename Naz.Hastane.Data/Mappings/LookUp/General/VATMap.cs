using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class VATMap : ClassMap<VAT>
    {
        public VATMap()
        {
            Table("tlkpvVAT");

            Id(x => x.Code).Column("SLB").Length(10);

            Map(x => x.ID0).Column("SLK").Length(2);
            Map(x => x.Value).Column("SLT").Length(150);
        }
    }
}
