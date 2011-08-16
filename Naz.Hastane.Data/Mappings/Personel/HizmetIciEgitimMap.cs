using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{

    public class HizmetIciEgitimMap : ClassMap<HizmetIciEgitim>
    {

        public HizmetIciEgitimMap()
        {
            Table("tblHizmetIciEgitim");
            LazyLoad();
            Id(x => x.ID).GeneratedBy.Identity().Column("ID");
            References(x => x.HizmetIciEgitimTipi).Column("HizmetIciEgitimTipiID").Not.Nullable();
            Map(x => x.BaslangicTarihi).Column("BaslangicTarihi").Not.Nullable();
            Map(x => x.BitisTarihi).Column("BitisTarihi").Not.Nullable();
            Map(x => x.Aciklama).Column("Aciklama");

            HasMany(x => x.PersonelHizmetIciEgitims).KeyColumn("HizmetIciEgitimID").Inverse();
        }
    }
}
