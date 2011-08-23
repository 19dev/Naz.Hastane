using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class QueueStatusMap : ClassMap<QueueStatus>
    {
        public QueueStatusMap()
        {
            Table("tlkpQueueStatus");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(50);
            Map(x => x.Code).Column("Code");
        }
    }
}
