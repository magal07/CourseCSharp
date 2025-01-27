﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    internal class BrazilTaxService : ITaxService // realização de interface
    {
        public double Tax(double amount)
        {
            if(amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
               return amount * 0.15;
            }
        }
    }
}
