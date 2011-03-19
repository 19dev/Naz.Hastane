using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities.StoredProcedure
{
    public class AccountingDailySummary
    {
        public virtual int RowNumber { get; set; }
        public virtual DateTime FTARIH { get; set; }
        public virtual string Aciklama { get; set; }

        public virtual string TCKIMLIKNO { get; set; }
        public virtual string HesapKodu { get; set; }
        public virtual string MakbuzNo { get; set; }
        public virtual double Tutar { get; set; }
        public virtual double FaturaTutari { get; set; }
    }
}
