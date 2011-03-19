using System;
using System.Collections.Generic;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public class BloodType 
    {
        public virtual int ID { get; set; }
        public virtual string Value { get; set; }
        public virtual int Code { get; set; }
    }
}
