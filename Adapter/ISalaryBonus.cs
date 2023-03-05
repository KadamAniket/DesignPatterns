using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface ISalaryBonus
    {
        public int CalculateSalaryBonus(Employee employees);
    }
}
