using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Takip Tipi")]
    public class FollowUpType : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "N";
    }
}
