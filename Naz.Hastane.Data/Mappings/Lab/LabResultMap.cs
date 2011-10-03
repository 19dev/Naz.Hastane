using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class LabResultMap : ClassMap<LabResult> 
	{
		public LabResultMap() 
		{
			Table("LABORSONUC");
			LazyLoad();
			
			CompositeId()
				.KeyProperty(x => x.KNR)
				.KeyProperty(x => x.SNR)
				.KeyProperty(x => x.TANIM)
				.KeyProperty(x => x.GRUP)
				.KeyProperty(x => x.CODE)
				.KeyProperty(x => x.TARIH)
				.KeyProperty(x => x.IND);
			
			Map(x => x.OZELKOD).Column("OZELKOD").Length(5);
			Map(x => x.PARISMI).Column("PARISMI").Not.Nullable().Length(30);
			Map(x => x.SONUC).Column("SONUC").Not.Nullable().Length(100);
			Map(x => x.BIRIMI).Column("BIRIMI").Not.Nullable().Length(20);
			Map(x => x.NORMAL1).Column("NORMAL1").Not.Nullable().Length(25);
			Map(x => x.NORMAL2).Column("NORMAL2").Not.Nullable().Length(25);
			Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(50);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE");
		}
	}
}
