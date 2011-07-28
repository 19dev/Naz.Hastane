using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings
{
    public class PatientMap : ClassMap<Patient>
    {
        // 63 Fields
        public PatientMap()
        {
            Table("ADRES");
            
            Id(x => x.PatientNo)        .Column("KNR")          .Length(6);

            Map(x => x.FirstName)       .Column("HASTAADI")     .Length(15) .Not.Nullable();
            Map(x => x.LastName)        .Column("HASTASOYADI")  .Length(30) .Not.Nullable();
            Map(x => x.TCId)            .Column("TCKIMLIKNO")   .Length(15);
            Map(x => x.FatherName)      .Column("BABAADI")      .Length(15);
            Map(x => x.MotherName)      .Column("ANAADI")       .Length(15);
            Map(x => x.Sex)             .Column("CINSIYETI")    .Length(1)  .Not.Nullable();
            Map(x => x.MaritalStatus)   .Column("MEDENI")       .Length(1)  .Not.Nullable();
            Map(x => x.BirthPlace)      .Column("DOGUMYERI")    .Length(15);
            Map(x => x.BirthDate)       .Column("DOGUMTARIHI")              .Not.Nullable();
            Map(x => x.Nationality)     .Column("UYRUGU")       .Length(5);
            Map(x => x.RegisteredTown)  .Column("NUFUSKAYITLIILCE").Length(50);
            Map(x => x.RegisteredCity)  .Column("NUFUSKAYITLIIL").Length(50);

            Map(x => x.BloodType)       .Column("KANGRUBU");
            Map(x => x.CanBeBloodDonour).Column("KANVEREBILIR") .Length(1)  .Not.Nullable();
            Map(x => x.MedControl)      .Column("ILACKONTROL")  .Length(1)  .Not.Nullable();
            Map(x => x.CV)              .Column("OZGECMIS")     .Length(5000);

            Map(x => x.HomeAddress)     .Column("EV_ADRES")     .Length(60);
            Map(x => x.HomeDistrict)    .Column("EV_MAHALLE")   .Length(50);
            Map(x => x.HomeTown)        .Column("EV_ILCE")      .Length(50);
            Map(x => x.HomePostCode)    .Column("EV_PK")        .Length(5);
            Map(x => x.HomeCity)        .Column("EV_SEHIR")     .Length(20);
            Map(x => x.HomePhone1)      .Column("EV_TEL1")      .Length(15);
            Map(x => x.HomePhone2)      .Column("EV_TEL2")      .Length(15);

            Map(x => x.JobName)         .Column("IS_ADI")       .Length(25);
            Map(x => x.JobAddress)      .Column("IS_ADRESI")    .Length(60);
            Map(x => x.JobPostCode)     .Column("IS_PK")        .Length(5);
            Map(x => x.JobCity)         .Column("IS_SEHIR")     .Length(20);
            Map(x => x.JobPhone1)       .Column("IS_TEL1")      .Length(15);
            Map(x => x.JobPhone2)       .Column("IS_TEL2")      .Length(15);
            Map(x => x.JobFax)          .Column("IS_FAX")       .Length(15);
            Map(x => x.JobNo)           .Column("IS_YERINO")    .Length(25);

            Map(x => x.Email)           .Column("EMAIL")        .Length(50);
            Map(x => x.Profession)      .Column("MESLEK")       .Length(20);

            References(x => x.InsuranceCompany).Column("PSG").LazyLoad().Cascade.None();    //      .Length(6)  .Not.Nullable();
            Map(x => x.ProtocolNo)      .Column("PROTNO")       .Length(20);
            Map(x => x.PatientContribution).Column("HASTAKATILIM").Length(1).Not.Nullable();
            Map(x => x.PatientLimit)    .Column("HASTALIMIT")               .Not.Nullable();
            Map(x => x.InsuranceType)   .Column("SIGORTATURU")  .Length(2);
            Map(x => x.TransferorInstitution).Column("DEVREDILENKURUM").Length(2);
            Map(x => x.Officer)         .Column("MEMUR")        .Length(20);
            Map(x => x.Relation)        .Column("YAKINLIK")     .Length(20);
            Map(x => x.Status)          .Column("DURUM")        .Length(1);

            Map(x => x.SIGMUD)          .Column("SIGMUD")       .Length(2);
            Map(x => x.SIGORTANO)       .Column("SIGORTANO")    .Length(15);
            Map(x => x.SIGORTALIKARTNO) .Column("SIGORTALIKARTNO").Length(20);
            Map(x => x.EMSNO)           .Column("EMSNO")        .Length(29);
            Map(x => x.BAGNO)           .Column("BAGNO")        .Length(20);
            Map(x => x.BAGKARNENO)      .Column("BAGKARNENO")   .Length(20);

            Map(x => x.IDType)          .Column("HUVIYETTIPI")  .Length(1);
            Map(x => x.IDNO)            .Column("HUVIYETNO")    .Length(15);
            Map(x => x.IDDate)          .Column("HUVIYETTARIHI").Length(10);
            Map(x => x.IDPlace)         .Column("HUVIYETVYER")  .Length(50);

            Map(x => x.ArchiveID)       .Column("ARSIVNO")      .Length(10);
            Map(x => x.CriminalArchiveID).Column("ADLIARSIVNO") .Length(10);

            Map(x => x.YKARTNO)         .Column("YKARTNO")      .Length(10);
            Map(x => x.GELHAST)         .Column("GELHAST")      .Length(20);
            Map(x => x.BORC)            .Column("BORC")                     .Not.Nullable();
            Map(x => x.ALACAK)          .Column("ALACAK")                   .Not.Nullable();

            Map(x => x.USER_ID)         .Column("USER_ID")      .Length(20) .Not.Nullable();
            Map(x => x.DATE_CREATE)     .Column("DATE_CREATE")              .Not.Nullable();
            Map(x => x.USER_ID_UPDATE)  .Column("USER_ID_UPDATE").Length(20);
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE");

            HasMany(x => x.PatientVisits).KeyColumn("KNR")
                .Inverse();
        }
    }
}
