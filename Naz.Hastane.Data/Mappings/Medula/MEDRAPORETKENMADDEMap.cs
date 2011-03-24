using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
    
    public class MEDRAPORETKENMADDEMap : ClassMap<MEDRAPORETKENMADDE> 
    {
        
        public MEDRAPORETKENMADDEMap() {
            
            Table("MEDRAPORETKENMADDE");

            CompositeId()
                .KeyReference(x => x.PatientVisit, "KNR", "SNR");

            //Map(x => x.KNR).Column("KNR").Not.Nullable().Length(50);
            //Map(x => x.SNR).Column("SNR").Not.Nullable().Length(50);
            Map(x => x.ETKENKODU).Column("ETKENKODU").Length(50);
            Map(x => x.ACIKLAMA).Column("ACIKLAMA").Length(100);
            Map(x => x.KULLANIMDOZ1).Column("KULLANIMDOZ1").Length(20);
            Map(x => x.KULLANIMDOZ2).Column("KULLANIMDOZ2").Length(20);
            Map(x => x.KULLANIMDOZBIRIM).Column("KULLANIMDOZBIRIM").Length(20);
            Map(x => x.KULLANIMPERIYOT).Column("KULLANIMPERIYOT").Length(20);
            Map(x => x.KULLANIMPERIYOTBIRIM).Column("KULLANIMPERIYOTBIRIM").Length(20);
            Map(x => x.FLAG_GONDER).Column("FLAG_GONDER");
        }
    }
}
