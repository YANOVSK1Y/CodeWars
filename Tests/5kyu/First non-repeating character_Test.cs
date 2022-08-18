using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._5kyu;

namespace Tests._5kyu
{
    [TestFixture]
    public class First_non_repeating_character_Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("a", First_non_repeating_character.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", First_non_repeating_character.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", First_non_repeating_character.FirstNonRepeatingLetter("moonmen"));
        }
        
    }
}
