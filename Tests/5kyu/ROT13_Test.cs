using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu; 

namespace Tests._5kyu
{
    public class ROT13_Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ROT13 example.", ROT13.Rot13("EBG13 rknzcyr."));
        }
    }
}
