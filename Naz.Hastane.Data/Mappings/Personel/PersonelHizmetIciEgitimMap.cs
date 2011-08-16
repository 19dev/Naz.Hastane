using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings 
{
		
	public class PersonelHizmetIciEgitimMap : ClassMap<PersonelHizmetIciEgitim> 
	{
		
		public PersonelHizmetIciEgitimMap() 
		{
			Table("tblPersonelHizmetIciEgitim");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			References(x => x.Personel).Column("PersonelID").Not.Nullable();
			References(x => x.HizmetIciEgitim).Column("HizmetIciEgitimID").Not.Nullable();
			Map(x => x.Aciklama).Column("Aciklama");
		}
	}
}
