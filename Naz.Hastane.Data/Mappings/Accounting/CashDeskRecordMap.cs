using System;
using Naz.Hastane.Data.Entities.Accounting;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.Accounting
{
    public class CashDeskRecordMap : ClassMap<CashDeskRecord>
    {
        public CashDeskRecordMap()
        {
            Table("KASA");

            Id(x => x.MAKNO).Column("MAKNO").Length(7);

            //References(x => x.PatientVisit).Columns("KNR", "SNR");
            Map(x => x.KNR).Column("KNR").Length(6); //1
            Map(x => x.SNR).Column("SNR").Length(3); //1

            Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(150); //1
            Map(x => x.ALTHESAPKODU).Column("ALTHESAPKODU").Length(50); //1
            Map(x => x.ARZT).Column("ARZT").Length(4); //1
            Map(x => x.BORCALACAK).Column("BORCALACAK").Length(1); //0
            Map(x => x.ce).Column("ce").Length(1); //1
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.dovizcinsi).Column("dovizcinsi").Length(50); //1
            Map(x => x.EKSIKODENEN).Column("EKSIKODENEN").Length(8); //0
            Map(x => x.FATURANO).Column("FATURANO").Length(7); //1
            Map(x => x.HESAPCODE).Column("HESAPCODE").Length(50); //1
            Map(x => x.HESAPKODU).Column("HESAPKODU").Length(50); //1
            Map(x => x.HFATURANO).Column("HFATURANO").Length(10); //1
            Map(x => x.HFATURATARIHI).Column("HFATURATARIHI").Length(10); //1
            Map(x => x.HNEREYEODENDI).Column("HNEREYEODENDI").Length(150); //1
            Map(x => x.ISIPTAL).Column("ISIPTAL").Length(1); //1
            Map(x => x.KATILIM).Column("KATILIM").Length(1); //1
            Map(x => x.MAKBUZGRUBU).Column("MAKBUZGRUBU").Length(2); //1
            Map(x => x.MAKBUZNO).Column("MAKBUZNO").Length(20); //0
            Map(x => x.MAKBUZTIPI).Column("MAKBUZTIPI").Length(1); //0
            Map(x => x.ODEMESEKLI).Column("ODEMESEKLI").Length(1); //0
            Map(x => x.PCARIKOD).Column("PCARIKOD").Length(10); //1
            Map(x => x.POSNO).Column("POSNO").Length(2); //1
            Map(x => x.SERVIS).Column("SERVIS").Length(2); //1
            Map(x => x.TARIH).Column("TARIH").Length(8); //0
            Map(x => x.TIPTAL).Column("TIPTAL").Length(1); //1
            Map(x => x.TUTAR).Column("TUTAR").Length(8); //0
            Map(x => x.tutardoviz).Column("tutardoviz").Length(8); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1
            Map(x => x.VEZNE).Column("VEZNE").Length(2); //0
        }
    }
}
