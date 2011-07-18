using System;
using Naz.Hastane.Data.Entities;
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data.Mappings.StoredProcedure
{
    public class AccountingDailySummaryMap : ClassMap<AccountingDailySummary>
    {
        public AccountingDailySummaryMap()
        {
            Table("sp_GetGunlukMuhasebeFisi");

            Id(x => x.RowNumber).Column("RowNumber");

            Map(x => x.OdemeSekli).Column("OdemeSekli");
            Map(x => x.Tarih).Column("FTARIH");
            Map(x => x.TCKIMLIKNO).Column("TCKIMLIKNO");
            Map(x => x.HesapKodu).Column("HesapKodu");
            Map(x => x.Aciklama).Column("Aciklama");
            Map(x => x.MakbuzNo).Column("MakbuzNo");
            Map(x => x.Tutar).Column("Tutar");
            Map(x => x.HizmetTutari).Column("FaturaTutari");
            Map(x => x.KDVOrani).Column("KDVOrani");
            Map(x => x.RecordType).Column("RecordType");
        }
    }
}
