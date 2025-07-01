using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator; // ✅ Import the Calculator class

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            double result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Sub_ShouldReturnCorrectSub()
        {
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }
    }
}
