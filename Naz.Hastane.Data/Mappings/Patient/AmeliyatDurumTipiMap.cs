using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class AmeliyatDurumTipiMap : ClassMap<AmeliyatDurumTipi> 
	{
		public AmeliyatDurumTipiMap() 
		{
			Table("tlkpAmeliyatDurumTipi");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
			Map(x => x.Value).Column("Value").Length(50);
		}
	}
}
