using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class What_s_a_Perfect_Power_anyway
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(n)); i++)
            {
                int k = Convert.ToInt32(Math.Log(n, i));
                if (Math.Pow(i, k) == n) return (i, k);
            }
            return null; 
        }
    }
}
