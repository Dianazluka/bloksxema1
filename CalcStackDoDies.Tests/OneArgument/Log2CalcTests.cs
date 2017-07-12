using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class Log2CalcTests
    {
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        public void Log2CalcTest(double first, double expected)
        {
            var calc = new Log2Calc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}