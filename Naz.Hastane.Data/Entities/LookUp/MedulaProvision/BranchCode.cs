using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Branş Kodu")]
    public class BranchCode : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "N";
    }
}
