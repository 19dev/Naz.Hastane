using System;

namespace Naz.Hastane.Data.Entities 
{
    public class AmeliyatListe : IDBase
    {
        public virtual DateTime Tarih { get; set; }
        public virtual string Oda { get; set; }
        public virtual string Hasta { get; set; }
        public virtual string Doktor { get; set; }
        public virtual string AmeliyatAdi { get; set; }
        public virtual AmeliyatDurumTipi Durum { get; set; }
        public virtual System.Nullable<System.DateTime> BaslangicSaati { get; set; }
        public virtual System.Nullable<System.DateTime> BitisSaati { get; set; }
    }
}
