﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaranteedIncome.Models
{
    public class ImmediateVariable: Annuity 
    {
        public override decimal[] CalculateReturns()
        {
            throw new NotImplementedException();
        }
    }
}
