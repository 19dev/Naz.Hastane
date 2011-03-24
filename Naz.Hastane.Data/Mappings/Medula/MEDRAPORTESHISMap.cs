using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
    
    public class MEDRAPORTESHISMap : ClassMap<MEDRAPORTESHIS> 
    {
        
        public MEDRAPORTESHISMap() {

            Table("MEDRAPORTESHIS");

            CompositeId()
                .KeyReference(x => x.PatientVisit, "KNR", "SNR");

            //Map(x => x.KNR).Column("KNR").Not.Nullable().Length(50);
            //Map(x => x.SNR).Column("SNR").Not.Nullable().Length(50);
            Map(x => x.RAPORBASTARIH).Column("RAPORBASTARIH");
            Map(x => x.RAPORBITTARIH).Column("RAPORBITTARIH");
            Map(x => x.RAPORTESKOD).Column("RAPORTESKOD").Length(50);
            Map(x => x.RAPORACIKLAMA).Column("RAPORACIKLAMA").Length(250);
            Map(x => x.ICD10TANIKODU).Column("ICD10TANIKODU").Length(20);
        }
    }
}
