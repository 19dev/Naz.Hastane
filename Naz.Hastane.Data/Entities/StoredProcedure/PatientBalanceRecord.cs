using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Naz.Hastane.Data.Entities.StoredProcedure
{
    [Description("Hasta Borç Alacak Kaydı")]
    public class PatientBalanceRecord
    {
        [Description("Sıra No")]
        public virtual int RowNumber { get; set; }
        [Description("Tarih")]
        public virtual DateTime Date { get; set; }
        [Description("Kayıt Tipi")]
        public virtual string Type { get; set; }
        [Description("Borç")]
        public virtual double Borc { get; set; }
        [Description("Alacak")]
        public virtual double Alacak { get; set; }
    }
}
