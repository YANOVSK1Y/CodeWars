using NUnit.Framework;
using Solutions._6kyu;

namespace Tests._6kyu
{
    public class Bit_Counting_Test
    {
        [Test]
        public void TestCase_Bit_Counting()
        {
            Assert.AreEqual(5, Bit_Counting.CountBits(1234)); 
        }
    }
}
