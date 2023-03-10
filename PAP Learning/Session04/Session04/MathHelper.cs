using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public static class MathHelper
    {

        public static double CalculatePower(double a, double b)
        {
            double result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            return result;

        }
    }
}
