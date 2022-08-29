using NUnit.Framework;
using System;
using Solutions._8kyu; 

namespace Tests._8kyu
{
    [TestFixture]
    public class Keep_up_the_hoop_Test
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("Keep at it until you get it", Keep_up_the_hoop.HoopCount(6), "Should work for 6");
            Assert.AreEqual("Great, now move on to tricks", Keep_up_the_hoop.HoopCount(22), "Should work for 22");
        }
    }
}
