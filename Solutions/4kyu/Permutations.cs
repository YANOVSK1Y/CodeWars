using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    public class Permutations
    {
        public static List<string> SinglePermutations(string s)
        {
            List<string> returnstrings = new List<string>();
            if (s.Length == 1)
            {
                returnstrings.Add(s);
            }
            else
            {
                for (int x = 0; x < s.Length; x++)
                {
                    returnstrings.AddRange(SinglePermutations(s.Remove(x, 1)).Select(z => s[x] + z));
                }
            }

            return returnstrings.Distinct().ToList();
        }
    }
}
