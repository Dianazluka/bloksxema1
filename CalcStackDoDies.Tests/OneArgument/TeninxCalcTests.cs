using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class TeninxCalcTests
    {
        [TestCase(2, 100)]
        [TestCase(0, 1)]
        [TestCase(-1, 0.1)]
        public void TeninxCalcTest(double first, double expected)
        {
            var calc = new TeninxCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}