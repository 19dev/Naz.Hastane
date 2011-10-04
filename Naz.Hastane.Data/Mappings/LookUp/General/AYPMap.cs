using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class AYPMap : ClassMap<AYP>
    {
        public AYPMap()
        {
            Table("tlkpAYP");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("strKisa").Length(255);
            Map(x => x.Code).Column("strUzun").Length(255);
        }
    }
}
