using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Common_Denominators
    {
        public static string convertFrac(long[,] lst)
        {
            var indices = Enumerable.Range(0, lst.GetLength(0));
            var d = indices.Aggregate(1L, (a, i) => a * lst[i, 1] / gcd(a, lst[i, 1]));
            return string.Concat(indices.Select(i => $"({d * lst[i, 0] / lst[i, 1]},{d})"));
        }

        private static long gcd(long a, long b) => b == 0 ? a : gcd(b, a % b);
    }
}
