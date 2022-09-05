using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._4kyu;

namespace Tests._4kyu
{
    public class Adding_Big_Numbers_Test
    {
        [Test]
        public void ASimpleKataTest()
        {
            Assert.AreEqual("110", Adding_Big_Numbers.Add("91", "19"));
            Assert.AreEqual("1111111111", Adding_Big_Numbers.Add("123456789", "987654322"));
            Assert.AreEqual("1000000000", Adding_Big_Numbers.Add("999999999", "1"));
        }
    }
}
