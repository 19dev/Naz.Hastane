using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data.Mappings.StoredProcedure
{
    public class Key1ValueMap : ClassMap<Key1ValueRecord>
    {
        public Key1ValueMap()
        {
            Table("sp_GetEczaneDagilim");

            Id(x => x.RowNumber).Column("RowNumber");

            Map(x => x.Key1).Column("Key1");
            Map(x => x.Value).Column("Value");
        }
    }
}
