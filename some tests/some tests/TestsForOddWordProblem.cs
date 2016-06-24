using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace some_tests
{
    [TestFixture]
    public class TestsForOddWordProblem
    {
        [Test]
        public void TestReverse()
        {
            var oddword = new OddWordProblem();
            var actual = oddword.Reverse("parrot");
            var expected = "torrap";
            Assert.AreEqual(expected, actual); 
        }
    }
}
