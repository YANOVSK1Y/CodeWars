using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    public static class Sum_Strings_as_Numbers
    {
        /// <summary>
        /// Given the string representations of two integers, return 
        /// the string representation of the sum of those integers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string sumStrings(string a, string b)
        {
            BigInteger.TryParse(a, out BigInteger a1);
            BigInteger.TryParse(b, out BigInteger b1);
            return Convert.ToString(a1 + b1);
        }
    }
}
