using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
	public class PatientAnamnesisDetailMap : ClassMap<PatientAnamnesisDetail>
	{
		public PatientAnamnesisDetailMap()
		{
			Table("TET_ANAMNEZ_DETAY");

			CompositeId()
				.KeyReference(x => x.PatientAnamnesis, "KNR", "SNR", "GELIS_TARIHI")
				.KeyProperty(x => x.TESHISKODU);

			Map(x => x.TANITIPI).Column("TANITIPI").Length(1);
			Map(x => x.BIRINCILTANI).Column("BIRINCILTANI").Length(1);
			Map(x => x.SIRANO).Column("SIRANO").Not.Nullable();
			Map(x => x.MEDSIRANO).Column("MEDSIRANO").Length(20);
			Map(x => x.MEDONAY).Column("MEDONAY").Length(2);
			Map(x => x.MEDOZDURUM).Column("MEDOZDURUM").Not.Nullable().Length(1);
			Map(x => x.FLAG_GONDER).Column("FLAG_GONDER");
		}
	}
}
