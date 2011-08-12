using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PersonelUnvaniMap : ClassMap<PersonelUnvani>
    {
        public PersonelUnvaniMap()
        {
            Table("tlkpPersonelUnvani");

            Id(x => x.ID).Column("ID");

            Map(x => x.Value).Column("Value").Length(255);
        }
    }
}
