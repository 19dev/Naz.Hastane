using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp.Special;

namespace Naz.Hastane.Data.Entities
{
    public class PatientVisitDetail
    {
        /// <summary>
        /// KNR; SNR
        /// </summary>
        public virtual PatientVisit PatientVisit { get; set; } //KNR; SNR
        /// <summary>
        /// SIRANO
        /// </summary>
        public virtual double DetailNo { get; set; } //SIRANO

        public virtual string AKOD { get; set; } //AKOD Ambar Kodu
        public virtual string TANIM { get; set; } //TANIM
        public virtual string GRUP { get; set; } //GRUP
        public virtual string CODE { get; set; } //CODE

        public virtual string NAME1 { get; set; } //NAME1    
        public virtual double ADET { get; set; } //ADET
        public virtual string UNITE { get; set; } //UNITE xx
        /// <summary>
        /// SATISF
        /// </summary>
        public virtual double PatientPrice { get; set; } //SATISF
        /// <summary>
        /// KSATISF
        /// </summary>
        public virtual double CompanyPrice { get; set; } //KSATISF
        public virtual double DSATISF { get; set; } //DSATISF
        public virtual double KDV { get; set; } //KDV
        public virtual DateTime TARIH { get; set; } //TARIH
        /// <summary>
        /// ARZT
        /// </summary>
        public virtual Doctor Doctor { get; set; } //Doctor; //ARZT
        public virtual string DoctorName
        {
            get
            {
                string result = "";
                try
                {
                    result = Doctor.Value;
                }
                catch
                {
                    result = "";
                }
                return result;
            }
        }
        public virtual string DoctorCode
        {
            get
            {
                string result = "";
                try
                {
                    result = Doctor.Code;
                }
                catch
                {
                    result = "";
                }
                return result;
                //if (Doctor == null)
                //    return "";
                //else
                //    return Doctor.Code;
            }
        }

        /// <summary>
        /// ARZT2
        /// </summary>
        public virtual Doctor Doctor2 { get; set; } //doktor2; //ARZT2
        public virtual string Doctor2Name
        {
            get
            {
                string result = "";
                try
                {
                    result = Doctor2.Value;
                }
                catch
                {
                    result = "";
                }
                return result;
            }
        }

        public virtual string PSG { get; set; } //PSG
        public virtual short HZLNO { get; set; } //HZLNO
        public virtual string MAKNO { get; set; } //MAKNO
        public virtual string KFATNO { get; set; } //KFATNO
        public virtual string FATURAEDILSIN { get; set; } //FATURAEDILSIN
        public virtual string ISLENDIMI { get; set; } //ISLENDIMI
        public virtual string PAKET { get; set; } //PAKET
        public virtual string LRGOR { get; set; } //LRGOR
        public virtual string BUTCODE { get; set; } //BUTCODE
        public virtual string BUTNAME { get; set; } //BUTNAME
        public virtual double ESKI_SATISF { get; set; } //ESKI_SATISF
        public virtual string KABUL { get; set; } //KABUL
        public virtual string ISODENDI { get; set; } //ISODENDI
        public virtual double CARIFIYAT { get; set; } //CARIFIYAT
        public virtual DateTime? ODEMETARIHI { get; set; } //ODEMETARIHI
        public virtual string ISDURUM { get; set; } //ISDURUM
        public virtual string PSEANS { get; set; } //PSEANS
        public virtual string SAGSOL { get; set; } //SAGSOL
        public virtual string EUSCORE { get; set; } //EUSCORE
        public virtual string HMAKNO { get; set; } //HMAKNO
        public virtual string HODENDI { get; set; } //HODENDI
        public virtual string AMAKNO { get; set; } //AMAKNO

        public virtual DateTime? HYATISTARIHI { get; set; } //HYATISTARIHI
        public virtual DateTime? HCIKISTARIHI { get; set; } //HCIKISTARIHI
        public virtual string REFGUNSAY { get; set; } //REFGUNSAY
        public virtual string ISLEMSIRANO { get; set; } //ISLEMSIRANO

        public virtual string MEDSIRANO { get; set; } //MEDSIRANO
        public virtual string MEDONAY { get; set; } //MEDONAY
        public virtual double MEDTUTAR { get; set; } //MEDTUTAR
        public virtual string MEDOZDURUM { get; set; } //MEDOZDURUM
        public virtual string MEDANOMALI { get; set; } //MEDANOMALI

        public virtual string TBASLANGICSAATI { get; set; } //TBASLANGICSAATI
        public virtual string TBITISSAATI { get; set; } //TBITISSAATI
        public virtual int TG { get; set; } //TG

        public virtual string USER_ID { get; set; } //USER_ID
        public virtual DateTime DATE_CREATE { get; set; } //DATE_CREATE
        public virtual string USER_ID_UPDATE { get; set; } //USER_ID_UPDATE
        public virtual DateTime? DATE_UPDATE { get; set; } //DATE_UPDATE

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PatientVisitDetail pv = obj as PatientVisitDetail;
            if (pv == null)
                return false;
            //if (this.PatientVisit == pv.KNR && this.SNR == pv.SNR && this.DetailNo == pv.DetailNo)
            if (this.PatientVisit == pv.PatientVisit && this.DetailNo == pv.DetailNo)
                    return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            //hash += (null == this.KNR ? 0 : this.KNR.GetHashCode());
            //hash += (null == this.SNR ? 0 : this.SNR.GetHashCode());
            hash += (null == this.PatientVisit ? 0 : this.PatientVisit.GetHashCode());
            hash += Convert.ToInt32(this.DetailNo);

            return hash;
        }
        //protected override void OnSaving()
        //{
        //    base.OnSaving();
        //    if (this.SIRANO == 0)
        //    {
        //        SIRANO =Double.Parse((new UnitOfWork()).ExecuteSproc("a_YeniHastaZiyaretIslemNo", KNR, SNR).ResultSet[0].Rows[0].Values[0].ToString());
        //        //KNR = HastaHelper.GetNewHastaNumber();
        //    }
        //}

        public virtual bool IsOKForDelete()
        {
            return String.IsNullOrWhiteSpace(MAKNO);
        }
    }
}
