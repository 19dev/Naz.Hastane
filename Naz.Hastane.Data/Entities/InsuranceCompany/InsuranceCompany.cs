using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class InsuranceCompany
    {
        public static readonly string SGKCode = "SGK";
        public static readonly string SGKAcilCode = "SLK";
        public static readonly string NormalPatientCode = "KRM000";
        public static readonly string SpecialPatientCode = "KRM008";

        /// <summary>
        /// PSG
        /// </summary>
        public virtual string Code { get; set; } // PSG; length(6); 0
        public virtual string KNR { get; set; } // KNR; length(5); 0

        /// <summary>
        /// ADI1
        /// </summary>
        public virtual string Name { get; set; } // ADI1; length(200); 0

        public virtual string ACILKATILIM { get; set; } // ACILKATILIM; length(1); 0
        public virtual string ADRZUS { get; set; } // ADRZUS; length(200); 1
        public virtual double ALACAK { get; set; } // ALACAK; length(8); 0
        public virtual char ANLASMADURUMU { get; set; } // ANLASMADURUMU; length(1); 0
        public virtual double BORC { get; set; } // BORC; length(8); 0
        public virtual double c_alacak { get; set; } // c_alacak; length(8); 1
        public virtual double c_borc { get; set; } // c_borc; length(8); 1
        public virtual string c_hesap_kodu { get; set; } // c_hesap_kodu; length(20); 1
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
        public virtual string DESTEKPSG { get; set; } // DESTEKPSG; length(6); 1
        public virtual string DRPAYNEZAMAN { get; set; } // DRPAYNEZAMAN; length(1); 0
        public virtual string DSTKDUS { get; set; } // DSTKDUS; length(1); 1
        public virtual double ECZBILGKATPAYI { get; set; } // ECZBILGKATPAYI; length(8); 0
        public virtual double ECZKATPAYI { get; set; } // ECZKATPAYI; length(8); 0
        public virtual double ECZMUAUCRETI { get; set; } // ECZMUAUCRETI; length(8); 0
        public virtual double EKSIKODENEN { get; set; } // EKSIKODENEN; length(8); 0
        //public virtual string EPOSTA { get; set; } // EPOSTA; length(50); 1
        public virtual string FAX { get; set; } // FAX; length(20); 1
        public virtual int FIXKURUM { get; set; } // FIXKURUM; length(2); 0
        public virtual string FIYLIST { get; set; } // FIYLIST; length(2); 1
        public virtual char HASTAKATILIM { get; set; } // HASTAKATILIM; length(1); 0
        public virtual double HASTALIMIT { get; set; } // HASTALIMIT; length(8); 0
        public virtual string hesap_kodu { get; set; } // hesap_kodu; length(100); 1
        public virtual string ILACINDIRIM { get; set; } // ILACINDIRIM; length(1); 1
        public virtual string ILACODE { get; set; } // ILACODE; length(1); 0
        public virtual string KURUMTIPI { get; set; } // KURUMTIPI; length(4); 0
        public virtual int lngKurumTipiID { get; set; } // lngKurumTipiID; length(4); 1
        public virtual string MKURUM { get; set; } // MKURUM; length(50); 1
        public virtual string MLIMIT { get; set; } // MLIMIT; length(50); 1
        public virtual string ORAN1 { get; set; } // ORAN1; length(150); 0
        public virtual string ORAN2 { get; set; } // ORAN2; length(150); 0
        public virtual char ORKA1 { get; set; } // ORKA1; length(10); 1
        public virtual char ORKA2 { get; set; } // ORKA2; length(10); 1
        public virtual char ORKA3 { get; set; } // ORKA3; length(10); 1
        public virtual string ORT { get; set; } // ORT; length(20); 0
        public virtual string OZELNOT { get; set; } // OZELNOT; length(16); 1
        public virtual string PFIYLIST { get; set; } // PFIYLIST; length(2); 0
        public virtual string PLZ { get; set; } // PLZ; length(5); 1
        public virtual string POLSURE { get; set; } // POLSURE; length(50); 1
        public virtual string SARFODE { get; set; } // SARFODE; length(1); 0
        public virtual string SEVKBASAMAK { get; set; } // SEVKBASAMAK; length(1); 1
        public virtual int SEVKGECSURE { get; set; } // SEVKGECSURE; length(2); 0
        public virtual string SIFIRGOSTER { get; set; } // SIFIRGOSTER; length(50); 0
        public virtual double SIRAID { get; set; } // SIRAID; length(8); 0
        public virtual string STR { get; set; } // STR; length(30); 1
        public virtual string TEL1 { get; set; } // TEL1; length(20); 1
        public virtual string TEL2 { get; set; } // TEL2; length(20); 1
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1
        public virtual string VADESURESI { get; set; } // VADESURESI; length(50); 1
        public virtual string VER { get; set; } // VER; length(20); 1
        public virtual string VERDAR { get; set; } // VERDAR; length(20); 1
        public virtual string VERNO { get; set; } // VERNO; length(20); 1
        public virtual string YETKILI { get; set; } // YETKILI; length(28); 1
        public virtual string YFIYLIST { get; set; } // YFIYLIST; length(2); 1

        public virtual string GetPriceList(string patientVisitType)
        {
            if (patientVisitType == PatientVisit.Hospitalized)
                return YFIYLIST;
            else
                return PFIYLIST;
        }
    }
}
