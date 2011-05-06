using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Data.DTO
{
    public class PatientVisitDetailWithProduct
    {
        public virtual PatientVisitDetail PatientVisitDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual double Discount { get; set; }
    }
}
