using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    public class Adding_Big_Numbers
    {
        ///<summary>
        ///We need to sum big numbers and we require your help.
        ///Write a function that returns the sum of two numbers.The input numbers
        ///are strings and the function must return a string.
        /// </summary>
        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
