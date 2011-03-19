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

            Map(x => x.FTARIH).Column("FTARIH");
            Map(x => x.Aciklama).Column("Aciklama");
            Map(x => x.TCKIMLIKNO).Column("TCKIMLIKNO");
            Map(x => x.HesapKodu).Column("HesapKodu");
            Map(x => x.MakbuzNo).Column("MakbuzNo");
            Map(x => x.Tutar).Column("Tutar");
            Map(x => x.FaturaTutari).Column("FaturaTutari");
        }
    }
}
