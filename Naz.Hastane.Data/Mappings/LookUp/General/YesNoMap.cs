using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class YesNoMap : ClassMap<YesNo>
    {
        public YesNoMap()
        {
            Table("tlkpYesNo");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
            Map(x => x.Code).Column("Code").Length(255);
        }
    }
}
