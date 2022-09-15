
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Simple_Fun_166_Best_Match_Test
    {
        [Test]
        public void BasicTests()
        {
            var kata = new Simple_Fun_166_Best_Match();

            Assert.AreEqual(1, kata.BestMatch(new int[] { 6, 4 }, new int[] { 1, 2 }));

            Assert.AreEqual(0, kata.BestMatch(new int[] { 1 }, new int[] { 0 }));

            Assert.AreEqual(4, kata.BestMatch(new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4 }));

            Assert.AreEqual(2, kata.BestMatch(new int[] { 3, 4, 3 }, new int[] { 1, 1, 2 }));

            Assert.AreEqual(1, kata.BestMatch(new int[] { 4, 3, 4 }, new int[] { 1, 1, 1 }));

        }
    }
}
