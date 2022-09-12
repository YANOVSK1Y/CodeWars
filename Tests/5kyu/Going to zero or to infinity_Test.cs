using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Going_to_zero_or_to_infinity_Test
    {
        [Test]
        public void Test01()
        {
            Assert.AreEqual(1.275, Going_to_zero_or_to_infinity.going(5));
        }
        [Test]
        public void Test02()
        {
            Assert.AreEqual(1.2125, Going_to_zero_or_to_infinity.going(6));
        }
        [Test]
        public void Test03()
        {
            Assert.AreEqual(1.173214, Going_to_zero_or_to_infinity.going(7));
        }
    }
}
