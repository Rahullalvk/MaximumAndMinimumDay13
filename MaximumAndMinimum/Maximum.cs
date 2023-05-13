using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAndMinimum
{
    class Maximum<T> where T : IComparable<T>
    {
        public static T GetMax(params T[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("At least one value must be provided.");
            }

            T max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }

            return max;
        }

        public static void PrintMax(T max)
        {
            Console.WriteLine("The maximum value is: " + max);
        }


    }
}
