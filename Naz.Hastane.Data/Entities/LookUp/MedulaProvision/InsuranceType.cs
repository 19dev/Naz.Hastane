using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    public enum InsuranceTypeValues
    {
        [Description("1")]
        Worker,
        [Description("2")]
        Retired,
        [Description("3")]
        SSKPersonnel,
        [Description("4")]
        Other
    }
    [Description("Sigorta Tipi")]
    public class InsuranceType : LookUpBase
    {
        public static readonly string DefaultValue = "1";
    }
}
