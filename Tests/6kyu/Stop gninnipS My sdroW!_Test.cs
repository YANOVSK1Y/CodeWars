using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._6kyu;

namespace Tests._6kyu
{
    [TestFixture]
    public class Stop_gninnipS_My_sdroW_Test
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Stop_gninnipS_My_sdroW.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Stop_gninnipS_My_sdroW.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Stop_gninnipS_My_sdroW.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Stop_gninnipS_My_sdroW.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Stop_gninnipS_My_sdroW.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Stop_gninnipS_My_sdroW.SpinWords("Just kidding there is still one more"));
        }
    }
}
