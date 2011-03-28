using System;
using Naz.Hastane.Data.Entities.Accounting;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.Accounting
{
    public class InvoiceTempMap : ClassMap<InvoiceTemp>
    {
        public InvoiceTempMap()
        {
            Table("FATURA_KESERKEN");

            Id(x => x.KNR).Column("KNR").Length(6);

            Map(x => x.ADET).Column("ADET").Length(8); //1
            Map(x => x.CODE).Column("CODE").Length(15); //1
            Map(x => x.FATURA_ID).Column("FATURA_ID").Length(20); //1
            Map(x => x.GRUP).Column("GRUP").Length(3); //1
            Map(x => x.KDV).Column("KDV").Length(8); //1
            Map(x => x.NAME1).Column("NAME1").Length(250); //1
            Map(x => x.PROVIZYONNO).Column("PROVIZYONNO").Length(50); //1
            Map(x => x.PSG).Column("PSG").Length(6); //1
            Map(x => x.SATISF).Column("SATISF").Length(8); //1
            Map(x => x.SIRAID).Column("SIRAID").Length(8); //1
            Map(x => x.SNR).Column("SNR").Length(3); //1
            Map(x => x.TANIM).Column("TANIM").Length(2); //1
            Map(x => x.TARIH1).Column("TARIH1").Length(8); //1
            Map(x => x.TARIH2).Column("TARIH2").Length(8); //1
            Map(x => x.TUTAR).Column("TUTAR").Length(8); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(100); //1
            Map(x => x.YAZIYLA).Column("YAZIYLA").Length(150); //1
        }
    }
}
