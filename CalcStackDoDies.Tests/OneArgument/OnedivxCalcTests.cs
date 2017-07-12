using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class OnedivxCalcTests
    {
        [TestCase(1, 1)]
        [TestCase(-5, -0.2)]
        [TestCase(100, 0.01)]
        public void OnedivxCalcTest(double first, double expected)
        {
            var calc = new OnedivxCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}