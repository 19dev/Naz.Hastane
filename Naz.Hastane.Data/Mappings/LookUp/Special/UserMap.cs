using System;
using Naz.Hastane.Data.Entities.LookUp.Special;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.Special
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("KULLANICILAR");

            Id(x => x.USER_ID).Column("USER_ID").Length(20);

            Map(x => x.ARZT).Column("ARZT").Length(4); //1
            Map(x => x.DATE_CREATED).Column("DATE_CREATED").Length(8); //1
            Map(x => x.DATE_UPDATED).Column("DATE_UPDATED").Length(8); //1
            Map(x => x.INDIRIMYUZDE).Column("INDIRIMYUZDE").Length(5); //1
            Map(x => x.ISBUSY).Column("ISBUSY").Length(1); //0
            Map(x => x.LASTACCESS).Column("LASTACCESS").Length(10); //0
            Map(x => x.PR2WIN).Column("PR2WIN").Length(1); //0
            Map(x => x.REV).Column("REV").Length(4); //1
            Map(x => x.STARTOBJ).Column("STARTOBJ").Length(100); //0
            Map(x => x.TARIH).Column("TARIH").Length(8); //0
            Map(x => x.TERM_PASS).Column("TERM_PASS").Length(10); //1
            Map(x => x.TESTER).Column("TESTER").Length(1); //0
            Map(x => x.USER_GRUP).Column("USER_GRUP").Length(2); //1
            Map(x => x.USER_PASS).Column("USER_PASS").Length(10); //0
            Map(x => x.VEZNE).Column("VEZNE").Length(2); //1
        }
    }
}
