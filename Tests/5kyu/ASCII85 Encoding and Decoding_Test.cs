
using System.Text;
using Solutions._5kyu;

namespace Tests._5kyu
{
    public class ASCII85_Encoding_and_Decoding_Test
    {

        [TestFixture]
        public class SolutionTest
        {
            public Encoding ascii = Encoding.ASCII;

            public string[] decoded = {
                  "easy",
                  "somewhat difficult"
                };

            public string[] encoded = {
                  "<~ARTY*~>",
                  "<~F)Po,GA(E,+Co1uAnbatCif~>",
                };

            [Test]
            public void testEncode_toAscii85()
            {
                for (int i = 0; i < 2; ++i)
                    Assert.AreEqual(encoded[i], ASCII85_Encoding_and_Decoding.toAscii85(ascii.GetBytes(decoded[i])));
            }
            [Test]
            public void testDecode_fromAscii85()
            {
                for (int i = 0; i < 2; ++i)
                    Assert.AreEqual(decoded[i], ascii.GetString(ASCII85_Encoding_and_Decoding.fromAscii85(encoded[i])));
            }
        }
    }
}
