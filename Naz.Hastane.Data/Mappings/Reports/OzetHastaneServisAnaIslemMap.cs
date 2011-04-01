using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities.Reports;

namespace Naz.Hastane.Data.Mappings.Reports
{
    public class OzetHastaneServisAnaIslemMap : ClassMap<OzetHastaneServisAnaIslem>
    {
        public OzetHastaneServisAnaIslemMap() 
        {
			Table("rtblOzetHastaneServisAnaIslem");
            Id(x => x.RowNumber).Column("RowNumber");

            Map(x => x.Key1).Column("Key1").Length(255);
            Map(x => x.Key2).Column("Key2").Length(255);
            Map(x => x.AdetC).Column("AdetC").Not.Nullable();
            Map(x => x.AdetP).Column("AdetP").Not.Nullable();
            Map(x => x.AdetP1).Column("AdetP1").Not.Nullable();
            Map(x => x.AdetY).Column("AdetY");
            Map(x => x.AdetY1).Column("AdetY1");
            Map(x => x.HastaC).Column("HastaC").Not.Nullable();
            Map(x => x.HastaP).Column("HastaP").Not.Nullable();
            Map(x => x.HastaP1).Column("HastaP1").Not.Nullable();
            Map(x => x.HastaY).Column("HastaY");
            Map(x => x.HastaY1).Column("HastaY1");
            Map(x => x.ToplamC).Column("ToplamC").Not.Nullable();
            Map(x => x.ToplamP).Column("ToplamP").Not.Nullable();
            Map(x => x.ToplamP1).Column("ToplamP1").Not.Nullable();
            Map(x => x.ToplamY).Column("ToplamY");
            Map(x => x.ToplamY1).Column("ToplamY1");
            Map(x => x.KisiBasiC).Column("KisiBasiC");
            Map(x => x.KisiBasiP).Column("KisiBasiP");
            Map(x => x.KisiBasiP1).Column("KisiBasiP1");
            Map(x => x.KisiBasiY).Column("KisiBasiY");
            Map(x => x.KisiBasiY1).Column("KisiBasiY1");
            Map(x => x.IslemBasiC).Column("IslemBasiC");
            Map(x => x.IslemBasiP).Column("IslemBasiP");
            Map(x => x.IslemBasiP1).Column("IslemBasiP1");
            Map(x => x.IslemBasiY).Column("IslemBasiY");
            Map(x => x.IslemBasiY1).Column("IslemBasiY1");
        }
    }
}
