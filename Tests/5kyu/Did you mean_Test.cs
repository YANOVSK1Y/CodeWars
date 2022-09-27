
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Did_you_mean_Test
    {
        [Test]
        public void TestDictionary1()
        {
            Did_you_mean kata = new Did_you_mean(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
            Assert.AreEqual("strawberry", kata.FindMostSimilar("strawbery"));
            Assert.AreEqual("cherry", kata.FindMostSimilar("berry"));
        }

        [Test]
        public void TestDictionary2()
        {
            Did_you_mean kata = new Did_you_mean(new List<string> { "javascript", "java", "ruby", "php", "python", "coffeescript" });
            Assert.AreEqual("java", kata.FindMostSimilar("heaven"));
            Assert.AreEqual("javascript", kata.FindMostSimilar("javascript"));
        }
    }
}
