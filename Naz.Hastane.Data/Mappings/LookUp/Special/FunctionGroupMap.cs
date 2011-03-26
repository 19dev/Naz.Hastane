using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class FunctionGroupMap : SubclassMap<FunctionGroup>
    {
        public FunctionGroupMap()
        {
            DiscriminatorValue("01");       // tlkpAnaIslem

            Map(x => x.FunctionGroupCode)       .Column("SLX"); // float
            References(x => x.FunctionGroupType).Column("lngAnaIslemID");
        }
    }
}
