using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAndMinimum
{
    public class Maximum
    {
        public static string GetMax(string num1, string num2, string num3)
        {
            string max = num1;

            if (string.Compare(num2, max) > 0)
            {
                max = num2;
            }

            if (string.Compare(num3, max) > 0)
            {
                max = num3;
            }

            return max;
        }
    }
}
