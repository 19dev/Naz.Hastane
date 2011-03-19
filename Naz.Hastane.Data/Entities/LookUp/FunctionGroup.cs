﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities.LookUp
{
    public class FunctionGroup : LookUpBase
    {
        public virtual string FunctionGroupCode { get; set; }   // null:, 0:, 1:Laboratuar, 2:, 3: Ameliyatlar, 5: Muayeneler, SGK Katılım, 6:Yatak
        public virtual FunctionGroupType FunctionGroupType { get; set; }
    }
}