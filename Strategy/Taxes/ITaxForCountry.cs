using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Taxes
{
    public interface ITaxForCountry
    {
        int CalculateTax(int amount);
        double CalculateFinalAmount(int amount);
    }
}
