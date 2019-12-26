using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTwoNumbers_Test1()
        {
            int expected = 12;
            int actual = CalculatorLibrary.CalculatorLibrary.AddTwoNumbers(3, 9);
            Assert.AreEqual(expected, actual);
        }

        public void SubtractTwoNumbers_Test1()
        {
            int expected = 10;
            int actual = CalculatorLibrary.CalculatorLibrary.SubtractTwoNumbers(25, 15);
            Assert.AreEqual(expected, actual);
        }
    }
}