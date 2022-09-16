using Solutions._4kyu;

namespace Tests._4kyu
{
    public class Permutations_Test
    {
        [Test]
        public void Example1()
        {
            Assert.AreEqual(new List<string> { "a" }, Permutations.SinglePermutations("a").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example2()
        {
            Assert.AreEqual(new List<string> { "ab", "ba" }, Permutations.SinglePermutations("ab").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example3()
        {
            Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, Permutations.SinglePermutations("aabb").OrderBy(x => x).ToList());
        }
    }
}
