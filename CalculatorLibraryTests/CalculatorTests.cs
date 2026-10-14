using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace CalculatorLibraryTests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            Assert.AreEqual(5.0, _calc.Add(2, 3));
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.AreEqual(2.0, _calc.Subtract(5, 3));
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.AreEqual(12.0, _calc.Multiply(3, 4));
        }

        [TestMethod]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(2.0, _calc.Divide(6, 3));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            _calc.Divide(5, 0);
        }

        [TestMethod]
        public void Power_ReturnsCorrectResult()
        {
            Assert.AreEqual(8.0, _calc.Power(2, 3));
        }
    }
}