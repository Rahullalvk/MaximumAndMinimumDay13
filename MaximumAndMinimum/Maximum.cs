using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAndMinimum
{
    public class Maximum
    {
        public static float GetMax(float num1, float num2, float num3)
        {
            float max = num1;

            if (num2.CompareTo(max) > 0)
            {
                max = num2;
            }

            if (num3.CompareTo(max) > 0)
            {
                max = num3;
            }

            return max;
        }
    }
}
