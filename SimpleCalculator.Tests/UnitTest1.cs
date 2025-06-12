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
    }
}
