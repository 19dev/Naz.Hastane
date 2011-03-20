using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public static class ServiceTypes
    {
        public static string ServiceTypePolyclinic = "0";
        public static string ServiceTypeHospitalise = "1";
        public static string ServiceTypeEmergency = "2";

    }

    public class Service : LookUpBase
    {
        public virtual string Type { get; set; } // SLXX 0: Poliklinik, 1:Yatış, 2:Acil SLXX

        //Map(x => x.Value).Column("SLX"); // float
        //Map(x => x.Value).Column("SLY"); // float Sorgu Turu Medula
        //Map(x => x.Value).Column("SLZ"); // float
        //Map(x => x.Value).Column("SLVV").Length(100);
        //Map(x => x.Value).Column("SLYY").Length(100);
        //Map(x => x.Value).Column("SLZZ").Length(100);
        //Map(x => x.Value).Column("SLXA").Length(20);  Branş Kodu Medula
        //Map(x => x.Value).Column("SLYA").Length(53); Tedavi Tipi Medula
        //Map(x => x.Value).Column("SLXB").Length(10); Takip Tipi Yoğun Bakım
        //Map(x => x.Value).Column("SEC"); // bit
        //Map(x => x.Value).Column("lngAnaIslemID"); //int
        //Map(x => x.Value).Column("lngDoktorServisTipiID"); //int
        //Map(x => x.Value).Column("Servis").Length(50);
        //Map(x => x.Value).Column("Sekreter").Length(50);
        //Map(x => x.Value).Column("SLBEk").Length(10);

        //private IList<SGKAutoExamination> _SGKAutoExaminations = new List<SGKAutoExamination>();

        //public virtual IList<SGKAutoExamination> SGKAutoExaminations
        //{
        //    get { return _SGKAutoExaminations; }
        //    set { _SGKAutoExaminations = value; }
        //}

        //public virtual void AddSGKAutoExamination(SGKAutoExamination ae)
        //{
        //    ae.Service = this;
        //    this.SGKAutoExaminations.Add(ae);
        //}
    }
}
