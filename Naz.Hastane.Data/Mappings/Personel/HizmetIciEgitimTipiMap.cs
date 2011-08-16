using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class HizmetIciEgitimTipiMap : ClassMap<HizmetIciEgitimTipi>
    {
        public HizmetIciEgitimTipiMap()
        {
            Table("tlkpHizmetIciEgitimTipi");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(50);
        }
    }
}
