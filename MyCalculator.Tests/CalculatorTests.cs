using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("Add")]        [Ignore]
        public void AddSimple()
        {
            //arrage
            Calculator calculator = new Calculator();
            //act
            int sum = calculator.Add(1, 2);
            //assert
            Assert.AreEqual(3, sum);
        }

        [TestMethod]
        public void DivideSimple()
        {
            Calculator calculator = new Calculator();
            int quotient = calculator.Divide(10, 5);
            Assert.AreEqual(2, quotient);
        }        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            Calculator calculator = new Calculator();
            calculator.Divide(10, 0);
        }
    }
}
