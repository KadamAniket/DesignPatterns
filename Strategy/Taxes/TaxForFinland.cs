using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Taxes
{
    public class TaxForFinland : ITaxForCountry
    {
        public int CalculateTax(int amount)
        {
            return 40;
        }

        public double CalculateFinalAmount(int amount)
        {
            return amount * 1.4;
        }

        
    }
}
