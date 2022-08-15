using System;
using System.Collections;
using NUnit.Framework;
using Solutions._4kyu;
using Solutions._4kyu;

namespace Tests._4kyu
{
    [TestFixture]
    public class Strip_Comments_Test
    {
        [Test]
        public void StripComments()
        {
            Assert.AreEqual(
                    "apples, pears\ngrapes\nbananas",
                    Strip_Comments.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", Strip_Comments.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

        }
    }
}
