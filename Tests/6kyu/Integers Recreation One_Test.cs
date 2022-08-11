
using NUnit.Framework;
using Solutions._6kyu; 

namespace Tests._6kyu
{
    [TestFixture]
    public class Integers_Recreation_One_Test
    {

        [Test]
        public void Test01()
        {
            Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", Integers_Recreation_One.listSquared(1, 250));
        }
        [Test]
        public void Test02()
        {
            Assert.AreEqual("[[42, 2500], [246, 84100]]", Integers_Recreation_One.listSquared(42, 250));
        }
        [Test]
        public void Test03()
        {
            Assert.AreEqual("[[287, 84100]]", Integers_Recreation_One.listSquared(250, 500));
        }
    } 
}
