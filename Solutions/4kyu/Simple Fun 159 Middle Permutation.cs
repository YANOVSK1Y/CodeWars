using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    public class Simple_Fun_159_Middle_Permutation
    {
        public string MiddlePermutation(string s)
        {
            s = new string(s.OrderByDescending(c => c).ToArray());
            int midLength = 1 + s.Length % 2;
            return s.Substring(s.Length / 2, midLength) + s.Remove(s.Length / 2, midLength);

        }
    }
}
