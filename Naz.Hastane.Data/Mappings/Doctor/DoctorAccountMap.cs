using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class DoctorAccountMap : ClassMap<DoctorAccount>
    {
        public DoctorAccountMap()
        {
            Table("DOKTORLAR");

            Id(x => x.KNR).Column("KNR").Length(5);

            Map(x => x.ADI1).Column("ADI1").Length(50); //0
            Map(x => x.ADRZUS).Column("ADRZUS").Length(100); //1
            Map(x => x.ALACAK).Column("ALACAK").Length(8); //0
            Map(x => x.ARZT).Column("ARZT").Length(4); //1
            Map(x => x.BORC).Column("BORC").Length(8); //0
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.DIPLOMANO).Column("DIPLOMANO").Length(30); //1
            Map(x => x.EKSIKODENEN).Column("EKSIKODENEN").Length(8); //0
            Map(x => x.FAX1).Column("FAX1").Length(20); //1
            Map(x => x.FAX2).Column("FAX2").Length(20); //1
            Map(x => x.HESAPTIPI).Column("HESAPTIPI").Length(1); //0
            Map(x => x.KDV).Column("KDV").Length(8); //0
            Map(x => x.ORT).Column("ORT").Length(20); //0
            Map(x => x.OZELISKONTO).Column("OZELISKONTO").Length(8); //0
            Map(x => x.OZELNOT).Column("OZELNOT").Length(2000); //1
            Map(x => x.PLZ).Column("PLZ").Length(5); //1
            Map(x => x.STR).Column("STR").Length(30); //1
            Map(x => x.TEL1).Column("TEL1").Length(20); //1
            Map(x => x.TEL2).Column("TEL2").Length(20); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1
            Map(x => x.VERDAR).Column("VERDAR").Length(20); //1
            Map(x => x.VERNO).Column("VERNO").Length(20); //1
        }
    }
}
