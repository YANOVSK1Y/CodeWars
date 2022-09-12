using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Going_to_zero_or_to_infinity
    {
        public static double going(int n)
        {
            double running = 1.0, term = 1.0;
            for (int i = n; i > 1; i--) running += (term *= 1.0 / i);
            return System.Math.Truncate(running * 1000000) / 1000000;
        }
    }
}
