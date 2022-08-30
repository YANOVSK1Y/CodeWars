using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions._4kyu; 

namespace Tests._4kyu
{
    [TestFixture]
    public class Simple_Fun_159_Middle_Permutation_Test
    {
        [Test]
        public void BasicTests()
        {
            var kata = new Simple_Fun_159_Middle_Permutation();

            Assert.AreEqual("bac", kata.MiddlePermutation("abc"));

            Assert.AreEqual("bdca", kata.MiddlePermutation("abcd"));

            Assert.AreEqual("cbxda", kata.MiddlePermutation("abcdx"));

            Assert.AreEqual("cxgdba", kata.MiddlePermutation("abcdxg"));

            Assert.AreEqual("dczxgba", kata.MiddlePermutation("abcdxgz"));

        }

    }
}

