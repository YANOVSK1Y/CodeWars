using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions._5kyu;

namespace Tests._5kyu
{
    public class RGB_To_Hex_Conversion_Test
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("FFFFFF", RGB_To_Hex_Conversion.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", RGB_To_Hex_Conversion.Rgb(255, 255, 300));
            Assert.AreEqual("000000", RGB_To_Hex_Conversion.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", RGB_To_Hex_Conversion.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", RGB_To_Hex_Conversion.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", RGB_To_Hex_Conversion.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", RGB_To_Hex_Conversion.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}

