using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientVisitRecordMap : ClassMap<PatientVisitRecord>
    {
        public PatientVisitRecordMap()
        {
            Table("BEHAND_DETAY");

            CompositeId()
                .KeyReference(x => x.PatientVisit, "KNR", "SNR")
                //.KeyProperty(x => x.KNR, "KNR")
                //.KeyProperty(x => x.SNR, "SNR")
                .KeyProperty(x => x.VisitDate, "GELISTARIHI");

            Map(x => x.ACIL_KONS).Column("ACIL_KONS").Length(1); //1
            Map(x => x.VisitType).Column("AMBU").Length(1); //0
            Map(x => x.Doctor).Column("ARZT").Length(4); //0
            Map(x => x.BRANSKODU).Column("BRANSKODU").Length(10); //1
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.EKSORGU).Column("EKSORGU").Length(1); //1
            Map(x => x.GELMEDİ).Column("GELMEDİ").Length(1); //1
            Map(x => x.GOZ_NOTLAR).Column("GOZ_NOTLAR").Length(100); //1
            Map(x => x.HASTABASNO).Column("HASTABASNO").Length(10); //1
            Map(x => x.ILISKILITAKIPNO).Column("ILISKILITAKIPNO").Length(20); //1
            Map(x => x.ISTEM_ARZT).Column("ISTEM_ARZT").Length(4); //1
            Map(x => x.ISTISNAIDURUM).Column("ISTISNAIDURUM").Length(2); //1
            Map(x => x.KONS).Column("KONS").Length(1); //1
            Map(x => x.KONS_SNR).Column("KONS_SNR").Length(3); //1
            Map(x => x.KONS_TARIH).Column("KONS_TARIH").Length(8); //1
            Map(x => x.KONT).Column("KONT").Length(1); //1
            Map(x => x.KONTROL_ID).Column("KONTROL_ID").Length(9); //1
            Map(x => x.MCIKISTARIHI).Column("MCIKISTARIHI").Length(8); //1
            Map(x => x.MUAYENEOLDU).Column("MUAYENEOLDU").Length(1); //0
            Map(x => x.NOTLAR).Column("NOTLAR").Length(100); //1
            Map(x => x.ONERILER).Column("ONERILER").Length(100); //1
            Map(x => x.PSG).Column("PSG").Length(10); //1
            Map(x => x.QueueNo).Column("SERNO").Length(5); //1
            Map(x => x.Servis).Column("SERVIS").Length(2); //0
            Map(x => x.SEVKTAKIPNO).Column("SEVKTAKIPNO").Length(10); //1
            Map(x => x.SIGORTALIKARTNO).Column("SIGORTALIKARTNO").Length(20); //1
            Map(x => x.TABKODU).Column("TABKODU").Length(2); //1
            Map(x => x.TAKIPTIPI).Column("TAKIPTIPI").Length(10); //1
            Map(x => x.TAKIPTURU).Column("TAKIPTURU").Length(10); //1
            Map(x => x.TEDAVITIPI).Column("TEDAVITIPI").Length(10); //1
            Map(x => x.TEDAVITURU).Column("TEDAVITURU").Length(10); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1
        }
    }
}
