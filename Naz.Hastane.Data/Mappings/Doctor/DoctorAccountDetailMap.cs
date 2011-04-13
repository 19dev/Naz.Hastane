using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class DoctorAccountDetailMap : ClassMap<DoctorAccountDetail>
    {
        public DoctorAccountDetailMap()
        {
            Table("DOKTORLAR_CARI");

            Id(x => x.CARI_ID).Column("CARI_ID");

            Map(x => x.KNR).Column("KNR").Length(5); //0

            Map(x => x.TARIH).Column("TARIH").Length(8); //0
            Map(x => x.BASLANGICTARIHI).Column("BASLANGICTARIHI").Length(8); //0
            Map(x => x.BITISTARIHI).Column("BITISTARIHI").Length(8); //0
            Map(x => x.TUTAR).Column("TUTAR").Length(8); //0
            Map(x => x.ISODENDI).Column("ISODENDI").Length(1); //0
            Map(x => x.ODEYEN).Column("ODEYEN").Length(20); //1

            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
        }
    }
}
