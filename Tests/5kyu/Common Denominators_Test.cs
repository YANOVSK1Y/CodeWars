using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Common_Denominators_Test
    {
        [Test]
        public void Test1()
        {

            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            Assert.AreEqual("(6,12)(4,12)(3,12)", Common_Denominators.convertFrac(lst));

        }
    }
}
