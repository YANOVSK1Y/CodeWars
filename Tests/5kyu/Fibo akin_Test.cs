using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu;

namespace Tests._5kyu
{
    public class Fibo_akin_Test
    {
        private static void dotest1(int n, int k, int expected)
        {
            Assert.AreEqual(expected, Fibo_akin.LengthSupUK(n, k));
        }
        private static void dotest2(int n, long expected)
        {
            Assert.AreEqual(expected, Fibo_akin.Comp(n));
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests lengthSupUK");
            dotest1(50, 25, 2);
            dotest1(3332, 973, 1391);
            dotest1(2941, 862, 1246);
            dotest1(3177, 573, 2047);
            dotest1(1745, 645, 474);
        }
        [Test]
        public static void test2()
        {
            Console.WriteLine("Basic Tests comp");
            dotest2(74626, 37128);
            dotest2(71749, 35692);
            dotest2(56890, 28281);
            dotest2(60441, 30054);
            dotest2(21361, 10581);
        }
    }
}
