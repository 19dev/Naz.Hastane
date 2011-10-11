using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class AmeliyatListeMap : ClassMap<AmeliyatListe> 
	{
		public AmeliyatListeMap() 
		{
			Table("tblAmeliyatListe");
			LazyLoad();
			Id(x => x.ID).GeneratedBy.Identity().Column("ID");
		
			Map(x => x.Tarih).Column("Tarih");
			Map(x => x.Oda).Column("Oda").Length(50);
			Map(x => x.Hasta).Column("Hasta").Length(50);
			Map(x => x.Doktor).Column("Doktor").Length(50);
			Map(x => x.AmeliyatAdi).Column("AmeliyatAdi").Length(50);
			References(x => x.Durum).Column("Durum");
			Map(x => x.BaslangicSaati).Column("BaslangicSaati");
			Map(x => x.BitisSaati).Column("BitisSaati");
		}
	}
}
