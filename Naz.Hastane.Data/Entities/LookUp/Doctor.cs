﻿using System;
using System.Collections.Generic;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public class Doctor : LookUpBase
    {
        public virtual Service Service { get; set; } // SLXX

        //Map(x => x.Value).Column("SLX"); // float Günlük Doktor SıraNo  => BEHAND.SERNO
        //Map(x => x.Value).Column("SLY"); // float
        //Map(x => x.Value).Column("SLZ"); // float
        //Map(x => x.Value).Column("SLVV").Length(100);
        //Map(x => x.Value).Column("SLYY").Length(100);
        //Map(x => x.Value).Column("SLZZ").Length(100);
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