using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void AdditionExpressionTest()
        {
            var calc = new Calculate();
            var actual = 2;
            Assert.AreEqual(calc.EvaluateExpression("1 + 1"), actual);
        }
        [Test]
        public void SubtractionExpressionTest()
        {
            var calc = new Calculate();
            var actual = 2;
            Assert.AreEqual(calc.EvaluateExpression("5 - 3"), actual);
        }
        [Test]
        public void MultiplicationExpressionTest()
        {
            var calc = new Calculate();
            var actual = 20;
            Assert.AreEqual(calc.EvaluateExpression("5 * 4"), actual);
        }
        [Test]
        public void DivisionExpressionTest()
        {
            var calc = new Calculate();
            var actual = 7;
            Assert.AreEqual(calc.EvaluateExpression("21 / 3"), actual);
        }
        [Test]
        public void ExpressionWith2Operators2()
        {
            var calc = new Calculate();
            var actual = 3;
            Assert.AreEqual(calc.EvaluateExpression("1 + 1 + 1"), actual); 
        }
        [Test]
        public void ExpressionWithTwoOperators2()
        {
            var calc = new Calculate();
            var actual = 11;
            Assert.AreEqual(calc.EvaluateExpression("3 + 4 + 4"), actual);
        }
        [Test]
        public void ExpressionWithThreeOperators()
        {
            var calc = new Calculate();
            var actual = 10;
            Assert.AreEqual(calc.EvaluateExpression("1 + 2 + 3 + 4"), actual); 
        }
       [Test]
        public void ExpressionWithThreeSubtractionOperators()
        {
            var calc = new Calculate();
            var actual = 2;
            Assert.AreEqual(calc.EvaluateExpression("5 - 2 - 1"), actual); 
        }
        [Test]
        public void ExpressionWithMultiplicationOperators()
        {
            var calc = new Calculate();
            var actual = 48;
            Assert.AreEqual(calc.EvaluateExpression("2 * 8 * 3"), actual); 
        }
        [Test]
        public void ExpressionWithThreeDivisionOperators()
        {
            var calc = new Calculate();
            var actual = 2;
            Assert.AreEqual(calc.EvaluateExpression("16 / 2 / 4"), actual); 
        }      
        [Test]
        public void ExpressionWith2DifferentOperators()
        {
            var calc = new Calculate();
            var actual = 4;
            Assert.AreEqual(calc.EvaluateExpression("3 + 6 - 5"), actual); 
        }
        [Test]
        public void ExpressionWith2DifferentOperators2()
        {
            var calc = new Calculate();
            var actual = 9;
            Assert.AreEqual(calc.EvaluateExpression("90 - 9 / 9"), actual); 
        }
        [Test]
        public void ExpressionWith2DifferentOperators3()
        {
            var calc = new Calculate();
            var actual = 20;
            Assert.AreEqual(calc.EvaluateExpression("9 + 1 * 2"), actual); 
        }
        [Test]
        public void ExpressionWith3DifferentOpterators()
        {
            var calc = new Calculate();
            var actual = 19;
            Assert.AreEqual(calc.EvaluateExpression("4 * 7 / 2 + 5"), actual); 
        }
         [Test]
        public void ExpressionVariousOperatorsNegativeNumbers()
        {
            var calc = new Calculate();
            var actual = -5;
            Assert.AreEqual(calc.EvaluateExpression("5 - 10 * 6 + 25"), actual); 
        }
         [Test]
        public void ExpressionVariousOperatorsNegativeNumbers2()
        {
            var calc = new Calculate();
            var actual = -3;
            Assert.AreEqual(calc.EvaluateExpression("5 * -7 + 11 / 8"), actual); 
        }
        [Test]
        public void LargerTest()
        {
            var calc = new Calculate();
            var actual = 56;
            Assert.AreEqual(calc.EvaluateExpression("1 + 14 * 4 - 12 / 6 * 7"), actual); 
        }
    }
}