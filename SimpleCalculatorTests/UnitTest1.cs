using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;


namespace SimpleCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestParsedExpression()
        {
            Parse parser = new Parse("225125+31256125");
            Assert.AreEqual(225125, parser.Number1);
            Assert.AreEqual("+", parser.Operator);
            Assert.AreEqual(31256125, parser.Number2);
        }

        [TestMethod]
        public void TestAddedExpression()
        {
            Parse parser = new Parse("3 + 5");
            Evaluate evaluater = new Evaluate(parser);
            Assert.AreEqual(8, evaluater.Product);
        }

        [TestMethod]
        public void TestSubtractedExpression()
        {
            Parse parser = new Parse("80 - 70");
            Evaluate evaluater = new Evaluate(parser);
            Assert.AreEqual(10, evaluater.Product);
        }

        [TestMethod]
        public void TestMultipliedExpression()
        {
            Parse parser = new Parse("12 * 5");
            Evaluate evaluater = new Evaluate(parser);
            Assert.AreEqual(60, evaluater.Product);
        }

        [TestMethod]
        public void TestDividedExpression()
        {
            Parse parser = new Parse("120 / 60");
            Evaluate evaluater = new Evaluate(parser);
            Assert.AreEqual(2, evaluater.Product);
        }
    }
}
