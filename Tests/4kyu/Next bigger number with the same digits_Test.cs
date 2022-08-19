using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._4kyu;

namespace Tests._4kyu
{
    [TestFixture]
    public class Next_bigger_number_with_the_same_digits_Test
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Small Number");
            Assert.AreEqual(21, Next_bigger_number_with_the_same_digits.NextBiggerNumber(12));
            Assert.AreEqual(531, Next_bigger_number_with_the_same_digits.NextBiggerNumber(513));
            Assert.AreEqual(2071, Next_bigger_number_with_the_same_digits.NextBiggerNumber(2017));
            Assert.AreEqual(441, Next_bigger_number_with_the_same_digits.NextBiggerNumber(414));
            Assert.AreEqual(414, Next_bigger_number_with_the_same_digits.NextBiggerNumber(144));
        }
    }
}
