using System;
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Lazy_Repeater_Test
    {

        [TestFixture]
        public class Sample_Tests
        {
            [Test]
            public void SampleTest()
            {
                Func<char> abc = Lazy_Repeater.MakeLooper("abc");
                // Two iterations of looper
                // 1
                Assert.AreEqual('a', abc());
                Assert.AreEqual('b', abc());
                Assert.AreEqual('c', abc());
                // 2
                Assert.AreEqual('a', abc());
                Assert.AreEqual('b', abc());
                Assert.AreEqual('c', abc());
            }
        }
    }
}
