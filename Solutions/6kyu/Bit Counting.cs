using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Solutions._6kyu
{
    public static class Bit_Counting
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(Convert.ToString(n, 2)).Where(item => item.Equals('1')).Count(); 
        }
    }
}
