using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class YabanciDilMap : ClassMap<YabanciDil>
    {
        public YabanciDilMap()
        {
            Table("tlkpYabanciDil");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(50);
        }
    }
}
