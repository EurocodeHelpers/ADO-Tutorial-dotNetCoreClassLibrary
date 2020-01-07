using MottMacdonald.Core;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,1,2)]
        [TestCase(10,20,30)]
        [TestCase(12,100,112)]
        public void AddTests(int x1, int x2, int expected)
        {
            var c = new MottMacdonald.Core.Calculator();            
            int actual = c.AddTwoNumbers(x1, x2);

             Assert.AreEqual(expected, actual);
        }

        [TestCase(99,33,66)]
        [TestCase(100,84,16)]
        [TestCase(112,60,52)]
        public void SubtractTests(int x1, int x2, int expected)
        {
            var c = new MottMacdonald.Core.Calculator();            
            int actual = c.SubtractTwoNumbers(x1, x2);

            Assert.AreEqual(expected, actual);
        }
    }
}