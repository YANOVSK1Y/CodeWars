
using Solutions._5kyu;

namespace Tests._5kyu
{
    public class Count_IP_Addresses_Test
    {
        [Test]
        public void SmapleTest()
        {
            Assert.AreEqual(50, Count_IP_Addresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            Assert.AreEqual(246, Count_IP_Addresses.IpsBetween("20.0.0.10", "20.0.1.0"));
            Assert.AreEqual((1L << 32) - 1L, Count_IP_Addresses.IpsBetween("0.0.0.0", "255.255.255.255"));
        }
    }
}
