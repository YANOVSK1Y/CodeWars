using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
using Solutions._4kyu; 

namespace Tests._4kyu
{
    public class ParceInt__Reloaded_Test
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual(1, ParceInt__Reloaded.ParseInt("one"));
            Assert.AreEqual(20, ParceInt__Reloaded.ParseInt("twenty"));
            Assert.AreEqual(246, ParceInt__Reloaded.ParseInt("two hundred forty-six"));
        }
    }
}
