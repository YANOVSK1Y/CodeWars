using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._4kyu;

namespace Tests._4kyu
{
    [TestFixture]
    public class Path_Finder_1_Сan_you_reach_the_exit_Test
    {

        [Test]
        public void sampleTests()
        {

            string a = ".W.\n" +
                       ".W.\n" +
                       "...",

                   b = ".W.\n" +
                       ".W.\n" +
                       "W..",

                   c = "......\n" +
                       "......\n" +
                       "......\n" +
                       "......\n" +
                       "......\n" +
                       "......",

                   d = "......\n" +
                       "......\n" +
                       "......\n" +
                       "......\n" +
                       ".....W\n" +
                       "....W.";

            Assert.AreEqual(true, Path_Finder_1_Сan_you_reach_the_exit.PathFinder(a));
            Assert.AreEqual(false, Path_Finder_1_Сan_you_reach_the_exit.PathFinder(b));
            Assert.AreEqual(true, Path_Finder_1_Сan_you_reach_the_exit.PathFinder(c));
            Assert.AreEqual(false, Path_Finder_1_Сan_you_reach_the_exit.PathFinder(d));
        }
    }
}
