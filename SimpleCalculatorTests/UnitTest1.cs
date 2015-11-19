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
            Assert.AreEqual("225125", parser.Number1);
            Assert.AreEqual("+", parser.Operator);
            Assert.AreEqual("31256125", parser.Number2);
        }
    }
}
