using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace RotateArrays
{
    [TestFixture]
    class Tests
    {
        //[Test]
        //public void TestRotation()
        //{
        //    var list = new List<int>()
        //    {
        //        1, 2, 3, 4, 5, 6, 7
        //    };
        //    var rotate = new Rotate();
        //    var expected = new List<int>()
        //    {
        //        4, 5, 6, 7, 1, 2, 3
        //    }; 
        //    var actual =  rotate.RotateList(list, 4);
        //    Assert.AreEqual(expected, actual); 
        //}
        [Test]
        public void StartingTests()
        {
            var list = new List<int>
            { 1, 2, 3 };

            var rotate = new Rotate();
            var expected = new List<int>
            { 1, 2, 3 };

            var actual = rotate.RotateList(list, 1);
            Assert.AreEqual(expected, actual); 
        }
    }
}
