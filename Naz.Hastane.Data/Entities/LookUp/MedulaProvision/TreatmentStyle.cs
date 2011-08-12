﻿using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Tedavi Şekli")]
    public class TreatmentStyle : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "A";
    }
}
