using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class Simple_Pig_Latin_Test
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Simple_Pig_Latin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Simple_Pig_Latin.PigIt("This is my string"));
        }
    }
}
