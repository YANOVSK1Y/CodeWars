using NUnit.Framework;
using System;
using Solutions._6kyu; 

namespace Tests
{
    [TestFixture]
    public class TheDeafRatsOfHamelin
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {"~O~O~O~O P", 0},
            new object[] {"P O~ O~ ~O O~", 1},
            new object[] {"~O~O~O~OP~O~OO~", 2},
        };
        
        [Test, TestCaseSource(typeof(TheDeafRatsOfHamelin), "Basic_Test_Cases")]
        public void Basic_Test(string town, int expected)
        {
            Assert.AreEqual(expected, The_Deaf_Rats_of_Hamelin.CountDeafRats(town));
        }
    }
}