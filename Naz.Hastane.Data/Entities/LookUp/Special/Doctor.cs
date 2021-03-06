﻿using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.Special
{
    /// <remarks>tlkpvDoctor</remarks>
    [Description("Doktor Tanımları")]
    public class Doctor : OldLookUp
    {
        [Description("Servis")]
        public virtual Service Service { get; set; } // SLXX
        [Description("Sıra No")]
        public virtual float QueueNo { get; set; } // SLX Günlük Doktor SıraNo  => BEHAND.SERNO
        [Description("Doktor Lisans No")]
        public virtual string LicenseNo { get; set; } // SLVV Length 100
        /// <summary>
        /// SLY
        /// </summary>
        [Description("İzinli")]
        public virtual float OnLeave { get; set; } // SLY 0:Çalışan, 1:İzinli

        //Map(x => x.Value).Column("SLZ"); // float
        //Map(x => x.Value).Column("SLYY").Length(100); Çalışma Günleri
        //Map(x => x.Value).Column("SLZZ").Length(100); Servisler ; ile ayrılmış
        //Map(x => x.Value).Column("SLXA").Length(20);
        //Map(x => x.Value).Column("SLYA").Length(53);
        //Map(x => x.Value).Column("SLXB").Length(10);
        //Map(x => x.Value).Column("SEC"); // bit
        //Map(x => x.Value).Column("lngAnaIslemID"); //int
        //Map(x => x.Value).Column("lngDoktorServisTipiID"); //int
        //Map(x => x.Value).Column("Servis").Length(50);
        //Map(x => x.Value).Column("Sekreter").Length(50);
        //Map(x => x.Value).Column("SLBEk").Length(10);
    }
}
