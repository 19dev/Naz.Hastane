using Naz.Hastane.Data.Entities.LookUp.General;
using FluentNHibernate.Mapping;

namespace Naz.Hastane.Data.Mappings.LookUp.General
{
    public class PaymentTypeMap : ClassMap<PaymentType>
    {
        public PaymentTypeMap()
        {
            Table("tlkpPaymentType");

            Id(x => x.ID);
            Map(x => x.Value).Length(255);
            Map(x => x.Code).Length(255);
        }
    }
}
