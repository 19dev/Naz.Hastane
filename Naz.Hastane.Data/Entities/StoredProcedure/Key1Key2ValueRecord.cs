using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.StoredProcedure
{
    public class Key1Key2ValueRecord : Key1ValueRecord
    {
        public virtual string Key2 { get; set; }
    }
}
