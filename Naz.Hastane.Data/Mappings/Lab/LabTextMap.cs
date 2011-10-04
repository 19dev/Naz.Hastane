using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities 
{
	public class LabTextMap : ClassMap<LabText> 
	{
		public LabTextMap() {
			Table("LABORTEXT");
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.LabRequest, "TANIM", "GRUP", "CODE", "KNR", "SNR", "TARIH");
			
			Map(x => x.LABTEXT).Column("LABTEXT").Length(2147483647);
		}
	}
}
