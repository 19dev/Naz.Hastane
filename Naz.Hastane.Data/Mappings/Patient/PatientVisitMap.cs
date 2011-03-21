using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientVisitMap : ClassMap<PatientVisit>
    {
        public PatientVisitMap()
        {
            Table("BEHAND");
            
            CompositeId()
                .KeyReference(x => x.Patient, "KNR")
                .KeyProperty(x => x.VisitNo, "SNR");

            Map(x => x.VisitDate).Column("BHDAT").Not.Nullable();
            Map(x => x.VisitType).Column("AMBU").Length(1).Not.Nullable();
            Map(x => x.ExitDate).Column("CIKTAR");
            Map(x => x.ExitTime).Column("CIKSAAT");

            Map(x => x.InvoiceNo).Column("FATURANO").Length(7);
            Map(x => x.InvoiceDate).Column("FATURATARIHI");
            Map(x => x.PatientTotal).Column("MTOPT");
            Map(x => x.InsuranceTotal).Column("KTOPT");
            Map(x => x.DTOPT).Column("DTOPT");

            Map(x => x.Doctor).Column("ARZT").Length(4);

            Map(x => x.Servis).Column("SERVIS").Length(2);
            Map(x => x.ODANO).Column("ODANO").Length(10);
            Map(x => x.ODAUCR).Column("ODAUCR");

            Map(x => x.PSG).Column("PSG").Length(10);
            Map(x => x.InsuranceType).Column("STURU").Length(2);
            Map(x => x.ProtocolNo).Column("PROTOKOLNO").Length(6);
            Map(x => x.ProvisionNo).Column("PROVIZYONNO").Length(40);
            Map(x => x.MEDFATURANO).Column("MEDFATURANO").Length(20);
            Map(x => x.MEDFATURATARIHI).Column("MEDFATURATARIHI");
            Map(x => x.MEDFATTUTAR).Column("MEDFATTUTAR");

            Map(x => x.TransferValidityPeriod).Column("SEVKGECSURE");
            Map(x => x.IMPF2).Column("IMPF2").Length(1);
            Map(x => x.KAR_NO).Column("KAR_NO").Length(7);
            Map(x => x.ARSIVNO).Column("ARSIVNO").Length(7);
            Map(x => x.TES_ANA).Column("TES_ANA").Length(2);
            Map(x => x.TES_CODE).Column("TES_CODE").Length(15);
            Map(x => x.HASTALIKSONU).Column("HASTALIKSONU").Length(1);
            Map(x => x.AMELIYAT).Column("AMELIYAT").Length(1);
            Map(x => x.DOGUM).Column("DOGUM").Length(1);
            Map(x => x.UCRETDURUMU).Column("UCRETDURUMU").Length(1);
            Map(x => x.QueueNo).Column("SERNO").Length(5);
            Map(x => x.GEL).Column("GEL").Length(1);
            Map(x => x.FIYATARTISMUAF).Column("FIYATARTISMUAF").Length(1);

            Map(x => x.ICMALNO).Column("ICMALNO").Length(10);
            Map(x => x.ICMALTARIHI).Column("ICMALTARIHI");

            Map(x => x.TAKIPNO).Column("TAKIPNO").Length(20);
            Map(x => x.TAKIPSEND).Column("TAKIPSEND").Length(2);
            Map(x => x.TAKIPTUTAR).Column("TAKIPTUTAR");
            Map(x => x.TAKIPTURU).Column("TAKIPTURU").Length(10);
            Map(x => x.SEVKTAKIPNO).Column("SEVKTAKIPNO").Length(20);

            Map(x => x.HZLNO).Column("HZLNO");
            Map(x => x.SIRAID).Column("SIRAID");
            Map(x => x.SpecialNote).Column("OZELNOT");
            Map(x => x.SupportInsCompany).Column("DESTEKPSG");
            Map(x => x.XLOCK).Column("XLOCK");
            Map(x => x.TABKODU).Column("TABKODU");
            Map(x => x.paket).Column("paket");
            Map(x => x.MYBUTKOD).Column("MYBUTKOD");
            Map(x => x.TESLIMNO).Column("TESLIMNO");
            Map(x => x.MCIKISTARIHI).Column("MCIKISTARIHI");
            Map(x => x.REFGUNSAY).Column("REFGUNSAY");
            Map(x => x.DESFATURATARIHI).Column("DESFATURATARIHI");
            Map(x => x.HASTABASNO).Column("HASTABASNO");
            Map(x => x.ILISKILITAKIPNO).Column("ILISKILITAKIPNO");
            Map(x => x.TEDAVITURU).Column("TEDAVITURU");
            Map(x => x.FARKTUTAR).Column("FARKTUTAR");
            Map(x => x.ARACIKLAMA).Column("ARACIKLAMA");
            Map(x => x.ARGONDERILDI).Column("ARGONDERILDI");
            Map(x => x.ARHATA).Column("ARHATA");
            Map(x => x.Status).Column("DURUM");

            Map(x => x.KONTROLTAR).Column("KONTROLTAR");
            Map(x => x.KONTROLT).Column("KONTROLT");
            Map(x => x.KONTROL).Column("KONTROL");

            Map(x => x.USER_ID).Column("USER_ID");
            Map(x => x.DATE_CREATE).Column("DATE_CREATE");
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE");
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");

            HasMany(x => x.PatientVisitDetails)
                .KeyColumns.Add("KNR","SNR")
                .Inverse()
                .Not.LazyLoad();
        }
    }
}
