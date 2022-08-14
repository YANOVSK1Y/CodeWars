using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._6kyu; 

namespace Tests._6kyu
{
    public class Write_Number_in_Expanded_Form_Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Write_Number_in_Expanded_Form.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
            Assert.That(Write_Number_in_Expanded_Form.ExpandedForm(12), Is.EqualTo("10 + 2"));
            Assert.That(Write_Number_in_Expanded_Form.ExpandedForm(42), Is.EqualTo("40 + 2"));
        }
    }
}
