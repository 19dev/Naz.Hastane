using System;
using System.Collections.Generic;

namespace Naz.Hastane.Data.Entities
{
    public class Patient
    {
        public virtual string PatientNo { get; set; } // KNR

        public virtual string FirstName { get; set; } //HASTAADI
        public virtual string LastName { get; set; } //HASTASOYADI
        public virtual string TCId { get; set; } //TCKIMLIKNO
        public virtual string FatherName { get; set; } //BABAADI
        public virtual string MotherName { get; set; } //ANAADI
        public virtual string Sex { get; set; } //CINSIYETI 1:Male, 2:Female
        public virtual string MaritalStatus { get; set; } //MEDENI B:Single, E:Married
        public virtual string BirthPlace { get; set; } //DOGUMYERI
        public virtual DateTime BirthDate { get; set; } //DOGUMTARIHI
        public virtual string Nationality { get; set; } //UYRUGU
        public virtual string RegisteredTown { get; set; } //NUFUSKAYITLIILCE
        public virtual string RegisteredCity { get; set; } //NUFUSKAYITLIIL

        public virtual string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public virtual int BloodType { get; set; } //KANGRUBU
        public virtual char CanBeBloodDonour { get; set; } //KANVEREBILIR
        public virtual char MedControl { get; set; } //ILACKONTROL
        public virtual string CV { get; set; } //OZGECMIS

        public virtual string HomeAddress { get; set; } //EV_ADRES
        public virtual string HomeDistrict { get; set; } //EV_MAHALLE
        public virtual string HomeTown { get; set; } //EV_ILCE
        public virtual string HomePostCode { get; set; } //EV_PK
        public virtual string HomeCity { get; set; } //EV_SEHIR
        public virtual string HomePhone1 { get; set; } //EV_TEL1
        public virtual string HomePhone2 { get; set; } //EV_TEL2

        public virtual string HomeInvoiceAddress
        {
            get
            {
                return FirstName + " " + LastName + "\n"
                    + HomeDistrict + " " + HomeAddress + "\n"
                    + HomeTown + " " + HomePostCode + " " + HomeCity;
            }
        }
        public virtual string JobName { get; set; } //IS_ADI
        public virtual string JobAddress { get; set; } //IS_ADRESI
        public virtual string JobPostCode { get; set; } //IS_PK
        public virtual string JobCity { get; set; } //IS_SEHIR
        public virtual string JobPhone1 { get; set; } //IS_TEL1
        public virtual string JobPhone2 { get; set; } //IS_TEL2
        public virtual string JobFax { get; set; } //IS_FAX
        public virtual string JobNo { get; set; } //IS_YERINO

        public virtual string Email { get; set; } //EMAIL
        public virtual string Profession { get; set; } //MESLEK

        public virtual InsuranceCompany InsuranceCompany { get; set; } //PSG
        public virtual string ProtocolNo { get; set; } //PROTNO
        public virtual char PatientContribution { get; set; } //HASTAKATILIM
        public virtual double PatientLimit { get; set; } //HASTALIMIT
        public virtual string InsuranceType { get; set; } //SIGORTATURU
        public virtual string TransferorInstitution { get; set; } //DEVREDILENKURUM
        public virtual string Officer { get; set; } //MEMUR
        public virtual string Relation { get; set; } //YAKINLIK
        public virtual char Status { get; set; } //DURUM

        public virtual string SIGMUD { get; set; } //SIGMUD
        public virtual string SIGORTANO { get; set; } //SIGORTANO
        public virtual string SIGORTALIKARTNO { get; set; } //SIGORTALIKARTNO
        public virtual string EMSNO { get; set; } //EMSNO
        public virtual string BAGNO { get; set; } //BAGNO
        public virtual string BAGKARNENO { get; set; } //BAGKARNENO

        public virtual char IDType { get; set; } //HUVIYETTIPI
        public virtual string IDNO { get; set; } //HUVIYETNO
        public virtual string IDDate { get; set; } //HUVIYETTARIHI
        public virtual string IDPlace { get; set; } //HUVIYETVYER

        public virtual string ArchiveID { get; set; } //ARSIVNO
        public virtual string CriminalArchiveID { get; set; } //ADLIARSIVNO

        public virtual string YKARTNO { get; set; } //YKARTNO
        public virtual string GELHAST { get; set; } //GELHAST
        public virtual double BORC { get; set; } //BORC
        public virtual double ALACAK { get; set; } //ALACAK

        public virtual string USER_ID { get; set; } //USER_ID
        public virtual DateTime DATE_CREATE { get; set; } //DATE_CREATE
        public virtual string USER_ID_UPDATE { get; set; } //USER_ID_UPDATE
        public virtual DateTime? DATE_UPDATE { get; set; } //DATE_UPDATE

        private IList<PatientVisit> _PatientVisits = new List<PatientVisit>();

        public virtual IList<PatientVisit> PatientVisits
        {
            get { return _PatientVisits; }
            set { _PatientVisits = value; }
        }

        public virtual void AddPatientVisit(PatientVisit pv)
        {
            pv.Patient = this;
            this.PatientVisits.Insert(0, pv);
        }

    }
}
