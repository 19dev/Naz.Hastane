using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public class LookUpBase
    {
        public virtual int ID { get; set; }
        public virtual string Value { get; set; }
        public virtual string Code { get; set; }
    }
}
