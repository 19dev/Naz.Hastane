using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings
{
    
    public class MEDESWLTASBILGISIMap : ClassMap<MEDESWLTASBILGISI>
    {
        
        public MEDESWLTASBILGISIMap() {

            Table("MEDESWLTASBILGISI");

            Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");

            References(x => x.PatientVisit).Columns("KNR", "SNR");
            //Map(x => x.KNR).Column("KNR").Length(10);
            //Map(x => x.SNR).Column("SNR").Length(10);

            Map(x => x.ESWLTASBOYUTU).Column("ESWLTASBOYUTU").Length(10);
            Map(x => x.ESWLTASLOKKODU).Column("ESWLTASLOKKODU").Length(10);
        }
    }
}
