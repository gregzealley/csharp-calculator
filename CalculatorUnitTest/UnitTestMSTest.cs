using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstTestProject;


namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCleanup]
        public void CleanUp()
        {
            calculator = null;
        }

        [TestMethod]
        public void WhenAddTwoNumbersThenCorrectResultReturned()
        {
            int result = calculator.Add(1, 1);

            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void WhenSubtractTwoNumbersThenCorrectResultReturned()
        {
            int result = calculator.Subtract(2, 1);

            Assert.AreEqual(1, result);
        }
    }


}
