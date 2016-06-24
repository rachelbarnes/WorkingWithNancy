using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OddWordProblem 
{
    [TestFixture]
     public class TestsForOddWordProblem
    {
        [Test]
        public void ReverseStringTest()
        {
            var reverseString = new ReverseEveryOddWord();
            var actual = reverseString.Reverse("Every other word");
            var expected = "drow rehto yrevE";
            Assert.AreEqual(expected, actual); 
        }
    }
}

