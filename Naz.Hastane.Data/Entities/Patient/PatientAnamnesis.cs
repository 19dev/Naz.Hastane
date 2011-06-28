using System.Collections.Generic; 
using System.Text; 
using System; 

namespace Naz.Hastane.Data.Entities {
    
    public class PatientAnamnesis 
    {
        public PatientAnamnesis() { }

        /// <summary>
        /// KNR, SNR, GELIS_TARIHI (BEHAND_DETAY)
        /// </summary>
        public virtual PatientVisitRecord PatientVisitRecord { get; set; }
        //public virtual string KNR { get; set; }
        //public virtual string SNR { get; set; }
        //public virtual System.DateTime GELIS_TARIHI { get; set; }

        public virtual string DOKTOR { get; set; }
        public virtual string SERVIS { get; set; }
        public virtual string PROTNO { get; set; }
  
        public virtual string OZSOYGECMIS { get; set; }
        public virtual string SISTEMSORGULARI { get; set; }
        public virtual string MUAYENEBULGULARI { get; set; }
        public virtual string ONTANI { get; set; }
        public virtual string TESHISVETEDAVI { get; set; }
        public virtual string OYKU { get; set; }
        public virtual string YAKINMA { get; set; }
        public virtual string NOTLAR { get; set; }
        public virtual System.Nullable<System.DateTime> MUAYENE_TARIHI { get; set; }

        public virtual string USER_ID { get; set; }
        public virtual System.DateTime DATE_CREATE { get; set; }
        public virtual string USER_ID_UPDATE { get; set; }
        public virtual System.Nullable<System.DateTime> DATE_UPDATE { get; set; }

        private IList<PatientAnamnesisDetail> _PatientAnamnesisDetails = new List<PatientAnamnesisDetail>();

        public virtual IList<PatientAnamnesisDetail> PatientAnamnesisDetails
        {
            get { return _PatientAnamnesisDetails; }
            set { _PatientAnamnesisDetails = value; }
        }

        public virtual void AddPatientAnamnesisDetail(PatientAnamnesisDetail pad)
        {
            pad.PatientAnamnesis = this;
            this.PatientAnamnesisDetails.Insert(PatientAnamnesisDetails.Count, pad);
        }

        public virtual void RemovePatientAnamnesisDetail(PatientAnamnesisDetail pad)
        {
            _PatientAnamnesisDetails.Remove(pad);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            PatientAnamnesis pa = obj as PatientAnamnesis;
            if (pa == null)
                return false;
            if (this.PatientVisitRecord == pa.PatientVisitRecord)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.PatientVisitRecord ? 0 : this.PatientVisitRecord.GetHashCode());

            return hash;
        }


    }
}
