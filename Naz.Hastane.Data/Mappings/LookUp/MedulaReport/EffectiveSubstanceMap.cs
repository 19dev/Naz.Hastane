using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Entities {
    
    
    public class EffectiveSubstanceMap : ClassMap<EffectiveSubstance> {

        public EffectiveSubstanceMap() 
        {
			Table("ETKEN_MADDE");

			Id(x => x.Code).GeneratedBy.Assigned().Column("KODU");

			Map(x => x.Value).Column("ACIKLAMA").Length(100);
			Map(x => x.ICERIK).Column("ICERIK").Length(50);
			Map(x => x.FORM).Column("FORM").Length(50);
			Map(x => x.MIKTAR).Column("MIKTAR").Length(50);
        }
    }
}
