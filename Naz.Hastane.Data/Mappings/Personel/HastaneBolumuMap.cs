using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class HastaneBolumuMap : ClassMap<HastaneBolumu>
    {
        public HastaneBolumuMap()
        {
            Table("tlkpHastaneBolumu");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
        }
    }
}
