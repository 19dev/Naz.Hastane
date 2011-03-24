using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.Mappings {
    
    
    public class MEDDIABETALISKANLIKLARMap : ClassMap<MEDDIABETALISKANLIKLAR> 
    {
        
        public MEDDIABETALISKANLIKLARMap() {

            Table("MEDDIABETALISKANLIKLAR");
            Id(x => x.SNO).GeneratedBy.Identity().Column("SNO");

            References(x => x.PatientVisit).Columns("KNR","SNR");
            //Map(x => x.KNR).Column("KNR").Length(6);
            //Map(x => x.SNR).Column("SNR").Length(3);
            Map(x => x.ALISKANLIKKODU).Column("ALISKANLIKKODU").Length(2);
        }
    }
}
