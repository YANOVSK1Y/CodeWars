using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Solutions._6kyu
{
    public class Which_are_in
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1.Distinct()
                             .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
                             .OrderBy(s => s)
                             .ToArray();
        }
    }
}
