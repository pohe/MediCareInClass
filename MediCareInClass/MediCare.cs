using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareInClass
{
    public class MediCare
    {

        public double SubsidisedExpense(double expense)
        {
            if (expense <0)
            {
                throw new ArgumentException();
            }
            else if (expense <= 1045)
            {
                return 0;
            }
            else if (expense <= 1750)
            {
                return 50;
            }
            else if (expense <= 3750)
            {
                return 75;
            }
            else if (expense <= 20636)
            {
                return 85;
            }
            else
            {
                return 100;
            }
        }

    }
}
