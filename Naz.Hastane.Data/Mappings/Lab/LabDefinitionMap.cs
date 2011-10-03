using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class LabDefinitionMap : ClassMap<LabDefinition> 
	{
		public LabDefinitionMap() {
			Table("LABTANIMLARI");
			LazyLoad();

			CompositeId()
				.KeyProperty(x => x.TANIM)
				.KeyProperty(x => x.GRUP)
				.KeyProperty(x => x.CODE)
				.KeyProperty(x => x.IND);

			Map(x => x.PARISMI).Column("PARISMI").Length(30);
			Map(x => x.BIRIMI).Column("BIRIMI").Length(15);
			Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(50);
			Map(x => x.TEXT).Column("TEXT").Length(2147483647);
			Map(x => x.MEDTAHLILKODU).Column("MEDTAHLILKODU").Length(10);
			Map(x => x.MEDGONDER).Column("MEDGONDER").Not.Nullable().Length(1);
		}
	}
}
