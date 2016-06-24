using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace ConsoleApplication1
{
    [TestFixture]
    public class TestingTests
    {
        [Test]
        public void Palindrome()
        {
            var palindrome = new TestingPalindromes();
            var actual = palindrome.PalindromeOrNo("racecar");
            Assert.AreEqual(true, actual); 
        }
    }
}
