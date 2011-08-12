using System;
using Naz.Hastane.Data.Entities.LookUp;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.MedulaProvision
{
    [Description("Hasta Akrabalık Durumu")]
    public class RelationType : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "0";
    }
}
