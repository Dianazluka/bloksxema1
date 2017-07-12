using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class Log10CalcTests
    {
        [TestCase(100, 2)]
        [TestCase(5, 0.6989)]
        [TestCase(10, 1)]
        public void Log10CalcTest(double first, double expected)
        {
            var calc = new Log10Calc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
        [Test]
        public void Againstzero()
        {
            var calc = new Log10Calc();
            Assert.Throws<Exception>(() => calc.Calculate(-1));
        }
    }
}