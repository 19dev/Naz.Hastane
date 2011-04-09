using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public enum PatientCardType
    {
        [Description("A")]
        Emergency,
        [Description("Y")]
        Hospitalized,
        [Description("P")]
        Polyclinic,
    }

    public class LookUpBase
    {
        public virtual int ID { get; set; }
        [Description("Kod")]
        public virtual string Code { get; set; }
        [Description("Değer")]
        public virtual string Value { get; set; }
    }
}
