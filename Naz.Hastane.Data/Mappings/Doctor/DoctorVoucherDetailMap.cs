using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class DoctorVoucherDetailMap : ClassMap<DoctorVoucherDetail>
    {
        public DoctorVoucherDetailMap()
        {
            Table("DOKTORLAR_MAKBUZ_DETAY");

            Id(x => x.DETAY_ID).Column("DETAY_ID");

            Map(x => x.AMBU).Column("AMBU").Length(1); //0
            Map(x => x.CARI_ID).Column("CARI_ID").Length(4); //1
            Map(x => x.CODE).Column("CODE").Length(15); //0
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.FATNO).Column("FATNO").Length(10); //0
            Map(x => x.FATURANO).Column("FATURANO").Length(10); //0
            Map(x => x.FATURATARIHI).Column("FATURATARIHI").Length(8); //0
            Map(x => x.GRUP).Column("GRUP").Length(3); //0
            Map(x => x.HKNR).Column("HKNR").Length(6); //0
            Map(x => x.HSIRANO).Column("HSIRANO").Length(8); //1
            Map(x => x.HSNR).Column("HSNR").Length(3); //1
            Map(x => x.ISODENDI).Column("ISODENDI").Length(1); //0
            Map(x => x.KNR).Column("KNR").Length(5); //0
            Map(x => x.PAY).Column("PAY").Length(8); //0
            Map(x => x.SIRA).Column("SIRA").Length(4); //0
            Map(x => x.TANIM).Column("TANIM").Length(2); //0
            Map(x => x.TOPLAM).Column("TOPLAM").Length(8); //0
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
        }
    }
}
