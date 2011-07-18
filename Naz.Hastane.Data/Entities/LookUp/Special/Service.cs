using System.Collections.Generic;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    public static class ServiceTypes
    {
        public static string ServiceTypePolyclinic = "0";
        public static string ServiceTypeHospitalise = "1";
        public static string ServiceTypeEmergency = "2";

    }

    /// <remarks>tlkpvService</remarks>
    [Description("Servis Tanımları")]
    public class Service : OldLookUpBase
    {
        [Description("Sorgu Türü")]
        public virtual float SorguTuru { get; set; } // SLY Sorgu Turu Medula ??
        [Description("Tipi")]
        public virtual string Type { get; set; } // SLXX 0: Poliklinik, 1:Yatış, 2:Acil SLXX
        [Description("Branş Kodu")]
        public virtual string BranchCode { get; set; } // SLXA  Branş Kodu Medula
        [Description("Tedavi Tipi")]
        public virtual string TreatmentType { get; set; } // SLYA Tedavi Tipi Medula

        //Map(x => x.Value).Column("SLX"); // float
        //Map(x => x.Value).Column("SLY"); // float Sorgu Turu Medula
        //Map(x => x.Value).Column("SLZ"); // float
        //Map(x => x.Value).Column("SLVV").Length(100);
        //Map(x => x.Value).Column("SLYY").Length(100);
        //Map(x => x.Value).Column("SLZZ").Length(100);
        //Map(x => x.Value).Column("SLXB").Length(10); Takip Tipi Yoğun Bakım
        //Map(x => x.Value).Column("SEC"); // bit
        //Map(x => x.Value).Column("lngAnaIslemID"); //int
        //Map(x => x.Value).Column("lngDoktorServisTipiID"); //int
        //Map(x => x.Value).Column("Servis").Length(50);
        //Map(x => x.Value).Column("Sekreter").Length(50);
        //Map(x => x.Value).Column("SLBEk").Length(10);

        private IList<SGKAutoExamination> _SGKAutoExaminations = new List<SGKAutoExamination>();

        public virtual IList<SGKAutoExamination> SGKAutoExaminations
        {
            get { return _SGKAutoExaminations; }
            set { _SGKAutoExaminations = value; }
        }

        public virtual void AddSGKAutoExamination(SGKAutoExamination ae)
        {
            ae.Service = this;
            this.SGKAutoExaminations.Add(ae);
        }

        private IList<SGKAutoExaminationSameDay> _SGKAutoExaminationSameDays = new List<SGKAutoExaminationSameDay>();

        public virtual IList<SGKAutoExaminationSameDay> SGKAutoExaminationSameDays
        {
            get { return _SGKAutoExaminationSameDays; }
            set { _SGKAutoExaminationSameDays = value; }
        }

        public virtual void AddSGKAutoExaminationSameDay(SGKAutoExaminationSameDay ae)
        {
            ae.Service = this;
            this.SGKAutoExaminationSameDays.Add(ae);
        }
    }
}
