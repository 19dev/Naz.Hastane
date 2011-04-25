using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Tedavi Tipi")]
    public class TreatmentType : LookUpBase
    {
        public static readonly string DefaultValue = "0";
    }
}
