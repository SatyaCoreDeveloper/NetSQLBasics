using System;

using NUnit.Framework;

namespace TestClass.UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        [TestCase(0,0,0)]
        [TestCase(-1, 10, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(10, 5, 10)]
        [TestCase(5000, 5000, 5000)]
        [TestCase(6000, 50, 5000)]
        public void Max_ValidNumbers_MaxNumber(int num1, int num2, int expected)
        {
            var calulator = new Calculator();
            var result = calulator.Max(num1, num2);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
