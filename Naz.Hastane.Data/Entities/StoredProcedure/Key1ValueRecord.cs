using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.StoredProcedure
{
    public class Key1ValueRecord
    {
        public virtual int RowNumber { get; set; }
        public virtual string Key1 { get; set; }
        public virtual double Value { get; set; }
    }
}
