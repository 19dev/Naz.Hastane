using System;
using System.Collections.Generic;

namespace Naz.Hastane.Data.Entities
{
    public class PatientVisit
    {
        public virtual Patient Patient { get; set; } //KNR
        /// <summary>
        /// SNR
        /// </summary>
        public virtual string VisitNo { get; set; } //SNR
        /// <summary>
        /// BHDAT
        /// </summary>
        public virtual DateTime VisitDate { get; set; } //BHDAT
        /// <summary>
        /// AMBU
        /// </summary>
        public virtual string VisitType { get; set; } //AMBU A, Y, P Kart Tipi
        /// <summary>
        /// CIKTAR
        /// </summary>
        public virtual DateTime? ExitDate { get; set; } //CIKTAR
        /// <summary>
        /// CIKSAAT
        /// </summary>
        public virtual string ExitTime { get; set; } //CIKSAAT
        /// <summary>
        /// FATURANO
        /// </summary>
        public virtual string InvoiceNo { get; set; } //FATURANO
        /// <summary>
        /// FATURATARIHI
        /// </summary>
        public virtual DateTime? InvoiceDate { get; set; } //FATURATARIHI
        /// <summary>
        /// MTOPT
        /// </summary>
        public virtual double PatientTotal { get; set; } //MTOPT Hasta Toplamı
        /// <summary>
        /// KTOPT
        /// </summary>
        public virtual double InsuranceTotal { get; set; } //KTOPT Kurum Toplamı
        public virtual double DTOPT { get; set; } //DTOPT Destek Kurum Toplamı
        public virtual string paket { get; set; } //paket P:var, Null: Yok
        /// <summary>
        /// DESTEKPSG
        /// </summary>
        public virtual string SupportInsCompany { get; set; } //DESTEKPSG
        public virtual DateTime? DESFATURATARIHI { get; set; } //DESFATURATARIHI
        /// <summary>
        /// SERVIS
        /// </summary>
        public virtual string Servis { get; set; } //SERVIS Service
        /// <summary>
        /// ARZT
        /// </summary>
        public virtual string Doctor { get; set; } //ARZT Doctor

        public virtual string ODANO { get; set; } //ODANO ODALAR.ODANO Tablosu
        public virtual char ODAUCR { get; set; } //ODAUCR

        public virtual string PSG { get; set; } //PSG Kurum
        public virtual string InsuranceType { get; set; } //STURU ?? SevkTuru Kullanılmıyor
        public virtual string ProtocolNo { get; set; } //PROTOKOLNO ??
        public virtual string ProvisionNo { get; set; } //PROVIZYONNO x

        public virtual string HASTABASNO { get; set; } //HASTABASNO (MEDFATURANO ile aynı?)
        public virtual string TAKIPNO { get; set; } //TAKIPNO Medula'dan gelen
        public virtual string TAKIPSEND { get; set; } //TAKIPSEND 9: gönderilmemiş(default), 3: gönderilmiş faturası kesilmemiş, 4: faturası kesilmiş
        public virtual double TAKIPTUTAR { get; set; } //TAKIPTUTAR Medula'ya fatura kesilince karşıdan gelen tutar
        /// <summary>
        /// TAKIPTURU
        /// </summary>
        public virtual string ProvisionType { get; set; } //TAKIPTURU Normal, Acil, Null
        /// <summary>
        /// ILISKILITAKIPNO
        /// </summary>
        public virtual string RelatedFollowUpNo { get; set; } //ILISKILITAKIPNO
        public virtual string SEVKTAKIPNO { get; set; } //SEVKTAKIPNO
        /// <summary>
        /// TEDAVITURU
        /// </summary>
        public virtual string TreatmentStyle { get; set; } //TEDAVITURU A:Ayakta, Y:Yatan, G:Günübirlik

        public virtual string MEDFATURANO { get; set; } //MEDFATURANO
        public virtual DateTime? MEDFATURATARIHI { get; set; } //MEDFATURATARIHI
        public virtual double MEDFATTUTAR { get; set; } //MEDFATTUTAR
        public virtual DateTime? MCIKISTARIHI { get; set; } //MCIKISTARIHI 
        public virtual double FARKTUTAR { get; set; } //FARKTUTAR
        public virtual string TESLIMNO { get; set; } //TESLIMNO Medula'nın kesilen faturaya dönderdiği numara
        /// <summary>
        /// SEVKGECSURE
        /// </summary>
        public virtual short TransferValidityPeriod { get; set; } //SEVKGECSURE
        public virtual string IMPF2 { get; set; } //IMPF2 Kurum Cariye İşlendi "C", Fatura Kesildi "A"
        public virtual string KAR_NO { get; set; } //KAR_NO Yatış Hastalarına Otomatik No Veriyor, kullanılmıyor
        public virtual string ARSIVNO { get; set; } //ARSIVNO Otomatik

        public virtual string TES_ANA { get; set; } //TES_ANA Teşhis Grup Kodu 01: Teşhis Grupları
        public virtual string TES_CODE { get; set; } //TES_CODE Çıkış İşlemini Seçerken Teşhis Kodu (Hangi Tablodan?)
        public virtual string HASTALIKSONU { get; set; } //HASTALIKSONU Çıkış İşlemi 1:Taburcu, 2:Ölü, Null
        public virtual string AMELIYAT { get; set; } //AMELIYAT Çıkış İşlemi {0..5)
        public virtual string DOGUM { get; set; } //DOGUM Çıkış İşlemi (0..3)
        public virtual string UCRETDURUMU { get; set; } //UCRETDURUMU Çıkış İşlemi (1..2)
        public virtual string REFGUNSAY { get; set; } //REFGUNSAY Refekatçi Gün Sayısı
        public virtual string TABKODU { get; set; } //TABKODU Taburcu Kodu (01..11) KEYDAT.SLK = 56 
        /// <summary>
        /// SERNO
        /// </summary>
        public virtual string QueueNo { get; set; } //SERNO
        public virtual string GEL { get; set; } //GEL ?? (1,2,3,5,6,7)
        public virtual string FIYATARTISMUAF { get; set; } //FIYATARTISMUAF

        public virtual string ICMALNO { get; set; } //ICMALNO x
        public virtual DateTime? ICMALTARIHI { get; set; } //ICMALTARIHI x

        public virtual short HZLNO { get; set; } //HZLNO ??
        public virtual double SIRAID { get; set; } //SIRAID ??
        public virtual string SpecialNote { get; set; } //OZELNOT
        public virtual bool XLOCK { get; set; } //XLOCK x
        public virtual string MYBUTKOD { get; set; } //MYBUTKOD xx

        public virtual string ARACIKLAMA { get; set; } //ARACIKLAMA Armakom
        public virtual bool ARGONDERILDI { get; set; } //ARGONDERILDI
        public virtual string ARHATA { get; set; } //ARHATA

        public virtual char Status { get; set; } //DURUM Cumhur Kapıönü
        public virtual DateTime? KONTROLTAR { get; set; } //KONTROLTAR
        public virtual DateTime? KONTROLT { get; set; } //KONTROLT
        public virtual char KONTROL { get; set; } //KONTROL

        public virtual string USER_ID { get; set; } //USER_ID
        public virtual DateTime DATE_CREATE { get; set; } //DATE_CREATE
        public virtual string USER_ID_UPDATE { get; set; } //USER_ID_UPDATE
        public virtual DateTime? DATE_UPDATE { get; set; } //DATE_UPDATE

        private IList<PatientVisitDetail> _PatientVisitDetails = new List<PatientVisitDetail>();

        public virtual IList<PatientVisitDetail> PatientVisitDetails
        {
            get { return _PatientVisitDetails; }
            set { _PatientVisitDetails = value; }
        }

        public virtual void AddPatientVisitDetail(PatientVisitDetail pvd)
        {
            pvd.PatientVisit = this;
            this.PatientVisitDetails.Insert(PatientVisitDetails.Count, pvd);
        }

        public virtual void RemovePatientVisitDetail(PatientVisitDetail pvd)
        {
            _PatientVisitDetails.Remove(pvd);
        }

        private IList<PatientVisitRecord> _PatientVisitRecords = new List<PatientVisitRecord>();

        public virtual IList<PatientVisitRecord> PatientVisitRecords
        {
            get { return _PatientVisitRecords; }
            set { _PatientVisitRecords = value; }
        }

        public virtual void AddPatientVisitRecord(PatientVisitRecord pvr)
        {
            pvr.PatientVisit = this;
            this.PatientVisitRecords.Insert(0, pvr);
        }

        private IList<AdvancePayment> _AdvancePayments = new List<AdvancePayment>();

        public virtual IList<AdvancePayment> AdvancePayments
        {
            get { return _AdvancePayments; }
            set { _AdvancePayments = value; }
        }

        public virtual void AddAdvancePayment(AdvancePayment pv)
        {
            pv.PatientVisit = this;
            this.AdvancePayments.Insert(0, pv);
        }
        //public virtual MedulaDiabetReport MedulaDiabetReport { get; set; }

        //protected override void OnSaving()
        //{
        //    base.OnSaving() { get; set; }
        //    if (this.ID.SNR == null || this.ID.SNR.Length == 0)
        //    {
        //        fID.SNR = (new UnitOfWork()).ExecuteSproc("a_YeniHastaZiyaretNo", ID.KNR).ResultSet[0].Rows[0].Values[0].ToString() { get; set; }
        //        //KNR = HastaHelper.GetNewHastaNumber() { get; set; }
        //    }
        //}

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PatientVisit pv = obj as PatientVisit;
            if (pv == null)
                return false;
            if (this.Patient == pv.Patient && this.VisitNo == pv.VisitNo)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.Patient ? 0 : this.Patient.GetHashCode());
            hash += (null == this.VisitNo ? 0 : this.VisitNo.GetHashCode());

            return hash;
        }


        public virtual bool IsOKForDelete()
        {
            if (!IsDetailVisitsOKForDelete())
                return false;
            return true;
        }

        public virtual bool IsDetailVisitsOKForDelete()
        {
            foreach (PatientVisitDetail pvd in PatientVisitDetails)
            {
                if (!pvd.IsOKForDelete())
                    return false;
            }
            return true;
        }
    }
}
