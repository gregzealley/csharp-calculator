using NUnit.Framework;
using FirstTestProject;

namespace Tests
{
    public class Tests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [Test]
        public void WhenAddTwoNumbersThenResultIsCorrect()
        {
            int result = calculator.Add(1, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void WhenSubtractTwoNumbersThenResultIsCorrect()
        {
            int result = calculator.Subtract(2, 1);

            Assert.AreEqual(1, result);
        }
    }
}