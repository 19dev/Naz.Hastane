using System;
using Naz.Hastane.Data.Entities.Accounting;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.Accounting
{
    public class InvoiceMap : ClassMap<Invoice>
    {
        public InvoiceMap()
        {
            Table("FATURA");

            Id(x => x.FATURA_ID).Column("FATURA_ID").Length(8);

            Map(x => x.AMAKNO).Column("AMAKNO").Length(50); //1
            Map(x => x.DATE_CREATE).Column("DATE_CREATE").Length(8); //0
            Map(x => x.DATE_UPDATE).Column("DATE_UPDATE").Length(8); //1
            Map(x => x.FAK).Column("FAK").Length(2); //0
            Map(x => x.FATURANO).Column("FATURANO").Length(20); //0
            Map(x => x.FATURATARIHI).Column("FATURATARIHI").Length(8); //0
            Map(x => x.FATURATIPI).Column("FATURATIPI").Length(1); //0
            Map(x => x.FATURATUTARI).Column("FATURATUTARI").Length(8); //0
            Map(x => x.HIZMETTUTARI).Column("HIZMETTUTARI").Length(8); //0
            Map(x => x.INDIRIM).Column("INDIRIM").Length(8); //0
            Map(x => x.IPTAL_NEDENI).Column("IPTAL_NEDENI").Length(50); //1
            Map(x => x.ISIPTAL).Column("ISIPTAL").Length(1); //1
            Map(x => x.ISODENDI).Column("ISODENDI").Length(1); //1
            Map(x => x.KALAN).Column("KALAN").Length(8); //1
            Map(x => x.KDVORANI).Column("KDVORANI").Length(1); //0
            Map(x => x.KDVTUTARI).Column("KDVTUTARI").Length(8); //0
            Map(x => x.KNR).Column("KNR").Length(6); //0
            Map(x => x.MAKBUZNO).Column("MAKBUZNO").Length(10); //1
            Map(x => x.MAKNO).Column("MAKNO").Length(7); //1
            Map(x => x.mk).Column("mk").Length(1); //0
            Map(x => x.NAME).Column("NAME").Length(100); //0
            Map(x => x.PSG).Column("PSG").Length(6); //1
            Map(x => x.SLNR).Column("SLNR").Length(10); //0
            Map(x => x.teslimNo).Column("teslimNo").Length(10); //1
            Map(x => x.USER_ID).Column("USER_ID").Length(20); //0
            Map(x => x.USER_ID_UPDATE).Column("USER_ID_UPDATE").Length(20); //1
            Map(x => x.VEZNE).Column("VEZNE").Length(2); //0
            Map(x => x.YUVARLAMA).Column("YUVARLAMA").Length(8); //0
            Map(x => x.ZHLKZ).Column("ZHLKZ").Length(2); //1
        }
    }
}
