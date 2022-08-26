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
    public class Where_my_anagrams_at_Test
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Where_my_anagrams_at.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
            Assert.AreEqual(new List<string> { "a" }, Where_my_anagrams_at.Anagrams("a", new List<string> { "a", "b", "c", "d" }));

        }

    }
}
