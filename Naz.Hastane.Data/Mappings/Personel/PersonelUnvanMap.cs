using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{

    public class PersonelUnvanMap : ClassMap<PersonelUnvan>
    {

        public PersonelUnvanMap()
        {
            Table("tblPersonelUnvan");
            LazyLoad();
            Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.Personel).Column("PersonelID").Not.Nullable();
            References(x => x.Unvan).Column("UnvanID");
            Map(x => x.BaslangicTarihi).Column("BaslangicTarihi");
            Map(x => x.Aciklama).Column("Aciklama");
        }
    }
}
