﻿using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp.General
{
    /// <remarks>tlkpPaymentType</remarks>
    [Description("Ödeme Şekli")]
    public class PaymentType : LookUpIdValueCode
    {
        public static readonly string DefaultValue = "0";
    }
}
