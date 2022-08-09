using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._6kyu;

namespace Tests._6kyu
{
    public class DataReverse_Test
    {

        [Test]
        public static void test1()
        {
            int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
            int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
            Assert.AreEqual(data2, Data_Reverse.DataReverse(data1));
        }

        [Test]
        public static void test2()
        {
            int[] data1 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
            int[] data2 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
            Assert.AreEqual(data2, Data_Reverse.DataReverse(data1));
        }

    }
}
