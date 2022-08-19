using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    public static class Next_bigger_number_with_the_same_digits
    {
        /// <summary>
        /// Create a function that takes a positive integer and returns the next
        /// bigger number that can be formed by rearranging its digits. For example:
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long NextBiggerNumber(long n)
        {
            String str = GetNumbers(n);
            for (long i = n + 1; i <= long.Parse(str); i++)
            {
                if (GetNumbers(n) == GetNumbers(i))
                {
                    return i;
                }
            }
            return -1;
            
        }
        public static string GetNumbers(long number)
        {
            return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
        }
    }
}
