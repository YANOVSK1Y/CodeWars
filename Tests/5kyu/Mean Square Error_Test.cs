using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Mean_Square_Error_Test
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(9, Mean_Square_Error.Solution(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(16.5, Mean_Square_Error.Solution(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }));
            Assert.AreEqual(1, Mean_Square_Error.Solution(new int[] { 0, -1 }, new int[] { -1, 0 }));
        }
    }
}
