using System;
using System.Collections.Generic;
using Naz.Hastane.Data.Entities.LookUp;
using FluentNHibernate.Mapping;
using System.ComponentModel;

namespace Naz.Hastane.Data.Mappings.LookUp
{
    public enum LookUpDiscriminators
    {
        [Description("00")]
        SystemSettings,
        [Description("01")] // tlkpAnaIslem
        FunctionGroup,
        [Description("02")]
        VAT,
        [Description("03")]
        Depository,
        [Description("04")]
        Warehouse,
        [Description("07")]
        Doctor,
        [Description("10")]
        PatientRelation,
        [Description("15")]
        PriceList,
        [Description("17")]
        Service,
        [Description("21")]
        DiagnoseGroup,
        [Description("30")]
        SubFunctionGroup,
        [Description("37")]
        City,
        [Description("51")]
        Nationality
    }

    public class OldLookUpBaseMap : ClassMap<OldLookUpBase>
    {
        public OldLookUpBaseMap()
        {
            Table("KEYDAT");
            DiscriminateSubClassesOnColumn("SLK");

            Id(x => x.Code)       .Column("SLB")  .Length(10);

            Map(x => x.ID0)     .Column("SLK")  .Length(2);
            Map(x => x.Value)   .Column("SLT")  .Length(150);

            //Map(x => x.Value).Column("SLX"); // float
            //Map(x => x.Value).Column("SLY"); // float
            //Map(x => x.Value).Column("SLZ"); // float
            //Map(x => x.Value).Column("SLVV").Length(100);
            //Map(x => x.Value).Column("SLXX").Length(100);
            //Map(x => x.Value).Column("SLYY").Length(100);
            //Map(x => x.Value).Column("SLZZ").Length(100);
            //Map(x => x.Value).Column("SLXA").Length(20);
            //Map(x => x.Value).Column("SLYA").Length(53);
            //Map(x => x.Value).Column("SLXB").Length(10);
            //Map(x => x.Value).Column("SEC"); // bit
            //Map(x => x.Value).Column("lngAnaIslemID"); //int
            //Map(x => x.Value).Column("lngDoktorServisTipiID"); //int
            //Map(x => x.Value).Column("Servis").Length(50);
            //Map(x => x.Value).Column("Sekreter").Length(50);
            //Map(x => x.Value).Column("SLBEk").Length(10);
        }
    }
}
