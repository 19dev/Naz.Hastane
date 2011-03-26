using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Services;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class FunctionGroupMap : SubclassMap<FunctionGroup>
    {
        public FunctionGroupMap()
        {
            DiscriminatorValue(LookUpDiscriminators.FunctionGroup.GetDescription());       // tlkpAnaIslem

            Map(x => x.FunctionGroupCode)       .Column("SLX"); // float
            References(x => x.FunctionGroupType).Column("lngAnaIslemID");
        }
    }
}
