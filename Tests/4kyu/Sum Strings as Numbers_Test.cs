using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._4kyu; 

namespace Tests._4kyu
{
    public  class Sum_Strings_as_Numbers_Test
    {
        [Test]
        public void Given123And456Returns579()
        {
            Assert.AreEqual("579", Sum_Strings_as_Numbers.sumStrings("123", "456"));
        }
    }
}
