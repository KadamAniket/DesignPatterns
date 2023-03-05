using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class EmployeeBonus
    {
        public int calculateEmployeeBonus(int workedHours)
        {
            if(workedHours > 60)
            {
                return 5000;
            }

            return 0;
        }
    }
}
