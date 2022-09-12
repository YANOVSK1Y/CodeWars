using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class What_s_a_Perfect_Power_anyway_Test
    {
        [Test]
        public void Test0()
        {
            Assert.IsNull(What_s_a_Perfect_Power_anyway.IsPerfectPower(0), "0 is not a perfect number");
        }

        [Test]
        public void Test1()
        {
            Assert.IsNull(What_s_a_Perfect_Power_anyway.IsPerfectPower(1), "1 is not a perfect number");
        }

        [Test]
        public void Test2()
        {
            Assert.IsNull(What_s_a_Perfect_Power_anyway.IsPerfectPower(2), "2 is not a perfect number");
        }

        [Test]
        public void Test3()
        {
            Assert.IsNull(What_s_a_Perfect_Power_anyway.IsPerfectPower(3), "3 is not a perfect number");
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual((2, 2), What_s_a_Perfect_Power_anyway.IsPerfectPower(4), "4 = 2^2");
        }

        [Test]
        public void Test5()
        {
            Assert.IsNull(What_s_a_Perfect_Power_anyway.IsPerfectPower(5), "5 is not a perfect power");
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual((2, 3), What_s_a_Perfect_Power_anyway.IsPerfectPower(8), "8 = 2^3");
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual((3, 2), What_s_a_Perfect_Power_anyway.IsPerfectPower(9), "9 = 3^2");
        }

        [Test]
        public void TestUpTo500()
        {
            var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
            foreach (var i in pp)
                Assert.IsNotNull(What_s_a_Perfect_Power_anyway.IsPerfectPower(i), $"{i} is a perfect power");
        }
    }
}
