using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
	public class PatientAnamnesisMap : ClassMap<PatientAnamnesis>
	{
		public PatientAnamnesisMap() 
		{
			Table("TET_ANAMNEZ");
            //Id(x => x.PatientVisitRecord).UniqueKey("KNR, SNR, GELIS_TARIHI");
            CompositeId()
                .KeyReference(x => x.PatientVisitRecord, "KNR", "SNR", "GELIS_TARIHI");
            //    .KeyProperty(x => x.KNR, "KNR")
            //    .KeyProperty(x => x.SNR, "SNR")
            //    .KeyProperty(x => x.GELIS_TARIHI, "GELIS_TARIHI");

			Map(x => x.OZSOYGECMIS).Column("OZSOYGECMIS");
			Map(x => x.SISTEMSORGULARI).Column("SISTEMSORGULARI");
			Map(x => x.MUAYENEBULGULARI).Column("MUAYENEBULGULARI");
			Map(x => x.ONTANI).Column("ONTANI").Length(100);
			Map(x => x.TESHISVETEDAVI).Column("TESHISVETEDAVI");
			Map(x => x.DOKTOR).Column("DOKTOR").Length(4);
			Map(x => x.SERVIS).Column("SERVIS").Length(2);
			Map(x => x.PROTNO).Column("PROTNO").Length(20);
			Map(x => x.OYKU).Column("OYKU").Length(1000);
			Map(x => x.YAKINMA).Column("YAKINMA").Length(2147483647);
			Map(x => x.NOTLAR).Column("NOTLAR").Length(50);
			Map(x => x.MUAYENE_TARIHI).Column("MUAYENE_TARIHI");

			Map(x => x.USER_ID).Column("USER_ID").Not.Nullable().Length(20);
			Map(x => x.DATE_CREATE).Column("DATE_CREATE").Not.Nullable();
			Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20);
			Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");

            HasMany(x => x.PatientAnamnesisDetails)
                .KeyColumns.Add("KNR", "SNR", "GELIS_TARIHI")
                .Inverse();
        }
	}
}
