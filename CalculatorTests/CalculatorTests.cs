using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryProb;
using System;
using ClassLibraryProb;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            double result = _calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            double result = _calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {

            double result = _calculator.Multiply(4, 5);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            double result = _calculator.Divide(15, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            _calculator.Divide(10, 0);
        }
    }
}