using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class YabanciDilDerecesiMap : ClassMap<YabanciDilDerecesi>
    {
        public YabanciDilDerecesiMap()
        {
            Table("tlkpYabanciDilDerecesi");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(50);
        }
    }
}
