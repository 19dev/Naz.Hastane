using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Tedavi Tipi")]
    public class TreatmentType : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "0";
        public static readonly string PhysicalTherapy = "2";
    }
}
