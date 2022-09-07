using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._5kyu
{
    public class Mean_Square_Error
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            return firstArray.Zip(secondArray, (x, y) => (x - y) * (x - y)).Average(); 
        }
        public static double Solution2(int[] firstArray, int[] secondArray)
        {
            double res = 0; 
            for (int i=0; i<Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                res += Math.Pow(firstArray[i] - secondArray[i], 2); 

            }
            return res / Math.Min(firstArray.Length, secondArray.Length); 
        }
    }
}
