using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class DoctorProcessMap : ClassMap<DoctorProcess>
    {
        public DoctorProcessMap()
        {
            Table("DOKTORPROCESS");

            Id(x => x.DP_ID).Column("DP_ID");

            Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(16); //0
            Map(x => x.ARZT).Column("ARZT").Length(4); //0
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.KNR).Column("KNR").Length(6); //0
            Map(x => x.SNR).Column("SNR").Length(3); //0
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1
        }
    }
}
