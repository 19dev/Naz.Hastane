using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class QueueStatusTypeMap : ClassMap<QueueStatusType>
    {
        public QueueStatusTypeMap()
        {
            Table("tlkpQueueStatusType");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(50);
        }
    }
}
