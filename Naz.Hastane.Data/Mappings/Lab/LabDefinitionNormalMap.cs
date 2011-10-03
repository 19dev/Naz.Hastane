using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class LabDefinitionNormalMap : ClassMap<LabDefinitionNormal> 
	{
		public LabDefinitionNormalMap() 
		{
			Table("LABTANIMLARINORMAL");
			LazyLoad();

			CompositeId()
				.KeyProperty(x => x.TANIM)
				.KeyProperty(x => x.GRUP)
				.KeyProperty(x => x.CODE)
				.KeyProperty(x => x.IND)
				.KeyProperty(x => x.CINSIYET);

			Map(x => x.SIRA).Column("SIRA");
			Map(x => x.DMY).Column("DMY").Length(1);
			Map(x => x.DMY1).Column("DMY1");
			Map(x => x.DMY2).Column("DMY2");
			Map(x => x.NORMAL1).Column("NORMAL1").Length(25);
			Map(x => x.NORMAL2).Column("NORMAL2").Length(25);
			Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(50);
			Map(x => x.PANIK1).Column("PANIK1").Length(25);
			Map(x => x.PANIK2).Column("PANIK2").Length(25);
		}
	}
}
