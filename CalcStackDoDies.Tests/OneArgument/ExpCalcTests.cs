using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class ExpCalcTests
    {
        [TestCase(2, 7.3891)]
        [TestCase(1, 2.7183)]
        [TestCase(0, 1)]
        public void ExpCalcTest(double first, double expected)
        {
            var calc = new ExpCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
