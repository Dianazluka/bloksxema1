using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class MinusxCalcTests
    {
        [TestCase(1, -1)]
        [TestCase(-5, 5)]
        [TestCase(16, -16)]
        public void MinusxCalcTest(double first, double expected)
        {
            var calc = new MinusxCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}