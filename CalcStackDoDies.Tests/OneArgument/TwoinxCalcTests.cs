using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class TwoinxCalcTests
    {
        [TestCase(2, 4)]
        [TestCase(0, 1)]
        [TestCase(-2, 0.25)]
        public void TwoinxCalcTest(double first, double expected)
        {
            var calc = new TwoinxCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}