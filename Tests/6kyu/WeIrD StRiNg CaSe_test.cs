using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._6kyu;

namespace Tests._6kyu
{
    [TestFixture]
    public class WeIrD_StRiNg_CaSe_Test
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual("ThIs", WeIrD_StRiNg_CaSe.ToWeirdCase("This"));
            Assert.AreEqual("Is", WeIrD_StRiNg_CaSe.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", WeIrD_StRiNg_CaSe.ToWeirdCase("This is a test"));
        }
    }
}

