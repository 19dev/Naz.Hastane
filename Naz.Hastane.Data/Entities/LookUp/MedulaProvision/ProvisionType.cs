﻿using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Provizyon Tipi")]
    public class ProvisionType : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "N";
        public static readonly string NormalValue = "N";
        public static readonly string EmergencyValue = "N";
    }
}
