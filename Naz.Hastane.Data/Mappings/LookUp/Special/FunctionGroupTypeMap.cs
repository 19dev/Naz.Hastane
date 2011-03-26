using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class FunctionGroupTypeMap : ClassMap<FunctionGroupType>
    {
        public FunctionGroupTypeMap()
        {
            Table("tlkpAnaIslemTipi");

            Id(x => x.ID);
            Map(x => x.Value).Column("strName").Length(255);
        }
    }
}
