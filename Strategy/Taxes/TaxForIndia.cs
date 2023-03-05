using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Taxes
{
    public class TaxForIndia : ITaxForCountry
    {
        public double CalculateFinalAmount(int amount)
        {
            return amount * 1.3;
        }

        public int CalculateTax(int amount)
        {
            return 30;
        }
    }
}
