using NUnit.Framework;
using Solutions._6kyu;

namespace Tests._6kyu
{
    [TestFixture]
    public class Which_are_in_Test
    {
        [Test]
        public void Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, Which_are_in.inArray(a1, a2));
        }
    }
}
