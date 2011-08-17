using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class UnvanMap : ClassMap<Unvan>
    {
        public UnvanMap()
        {
            Table("tlkpUnvan");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
        }
    }
}
