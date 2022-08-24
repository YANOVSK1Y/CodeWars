using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{   /// <summary>
    /// Complete the function scramble(str1, str2) that returns true if a
    /// portion of str1 characters can be rearranged to match str2, otherwise returns false.
    /// 
    ///Notes:
    ///Only lower case letters will be used(a-z). No punctuation or digits will be included.
    ///Performance needs to be considered.
    /// </summary>
    public static class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
        }

    }
}
