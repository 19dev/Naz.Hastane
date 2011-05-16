using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data.Mappings.StoredProcedure
{
    public class Key1Key2ValueMap : ClassMap<Key1Key2ValueRecord>
    {
        public Key1Key2ValueMap()
        {
            Table("sp_GetEczaneDagilim");

            Id(x => x.RowNumber).Column("RowNumber");

            Map(x => x.Key1).Column("Key1");
            Map(x => x.Key2).Column("Key2");
            Map(x => x.Value).Column("Value");
        }
    }
}
