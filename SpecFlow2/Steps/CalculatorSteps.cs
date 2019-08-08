using FirstTestProject;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlow2.Steps
{
    [Binding]
    class CalculatorSteps
    {
        private Calculator calculator;
        private int firstNum;
        private int secondNum;
        int actualResult;

        [BeforeScenario]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Given(@"I have two numbers (.*) and (.*)")]
        public void GivenIHaveTwoNumbersAnd(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }

        [When(@"I add these together")]
        public void WhenIAddTheseTogether()
        {
            actualResult = calculator.Add(firstNum, secondNum);
        }

        [Then(@"the correct result of (.*) is provided")]
        public void ThenTheCorrectResultOfIsProvided(int expectedResult)
        {
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
