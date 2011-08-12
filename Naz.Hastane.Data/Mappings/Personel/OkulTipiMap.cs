using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class OkulTipiMap : ClassMap<OkulTipi>
    {
        public OkulTipiMap()
        {
            Table("tlkpOkulTipi");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(50);
            Map(x => x.Rank).Column("Rank");
        }
    }
}
