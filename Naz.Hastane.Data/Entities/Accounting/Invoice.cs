using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities.Accounting
{
    public class Invoice
    {
        /// <summary>
        /// KEYDAT "00","FATNO" alanında son kesilen FaturaNo
        /// </summary>
        public virtual string FATURA_ID { get; set; } // FATURA_ID; length(8); 0 

        public virtual string KNR { get; set; } // KNR; length(6); 0

        public virtual string SLNR { get; set; } // SLNR; length(10); 0
        public virtual string FATURANO { get; set; } // FATURANO; length(20); 0
        public virtual DateTime FATURATARIHI { get; set; } // FATURATARIHI; length(8); 0
        public virtual double HIZMETTUTARI { get; set; } // HIZMETTUTARI; length(8); 0
        public virtual double INDIRIM { get; set; } // INDIRIM; length(8); 0
        public virtual double KDVTUTARI { get; set; } // KDVTUTARI; length(8); 0
        public virtual double YUVARLAMA { get; set; } // YUVARLAMA; length(8); 0
        public virtual double FATURATUTARI { get; set; } // FATURATUTARI; length(8); 0
        public virtual string KDVORANI { get; set; } // KDVORANI; length(1); 0

        public virtual string NAME { get; set; } // NAME; length(100); 0
        /// <summary>
        /// H: Hasta, K: Kurum, M:?
        /// </summary>
        public virtual string FATURATIPI { get; set; } // FATURATIPI; length(1); 0 
        public virtual string VEZNE { get; set; } // VEZNE; length(2); 0
        /// <summary>
        /// K: Hasta, A: Açık (Kurum), HA: Hasta Açık, N:, T:
        /// </summary>
        public virtual string FAK { get; set; } // FAK; length(2); 0 
        public virtual string ZHLKZ { get; set; } // ZHLKZ; length(2); 1 "N"
        /// <summary>
        /// Kurum Kodu
        /// </summary>
        public virtual string PSG { get; set; } // PSG; length(6); 1 
        public virtual string ISIPTAL { get; set; } // ISIPTAL; length(1); 1 1: İptal, Null
        /// <summary>
        /// 1: Ödendi, 0, Null: Ödenmedi (Açık Fatura)
        /// </summary>
        public virtual string ISODENDI { get; set; } // ISODENDI; length(1); 1 
        /// <summary>
        /// KEYDAT "00","MAKNO" alanında son kesilen FaturaNo
        /// </summary>
        public virtual string MAKNO { get; set; } // MAKNO; length(7); 1 
        public virtual char mk { get; set; } // mk; length(1); 0 H
        public virtual string teslimNo { get; set; } // teslimNo; length(10); 1 Boş
        public virtual string MAKBUZNO { get; set; } // MAKBUZNO; length(10); 1 Boş
        //public virtual double SEC { get; set; } // SEC; length(8); 1 ??
        public virtual double KALAN { get; set; } // KALAN; length(8); 1 ??
        /// <summary>
        /// Açık Fatura Makbuz No
        /// </summary>
        public virtual string AMAKNO { get; set; } // AMAKNO; length(50); 1 
        public virtual string IPTAL_NEDENI { get; set; } // IPTAL_NEDENI; length(50); 1 Boş

        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 0
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
        public virtual string USER_ID { get; set; } // USER_ID; length(20); 0
        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(20); 1
    }
}
