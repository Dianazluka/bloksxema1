using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class CosgradCalcTests
    {
        [TestCase(0, 1)]
        [TestCase(180, -1)]
        [TestCase(90, 0)]
        public void CosgradCalcTest(double first, double expected)
        {
            var calc = new CosgradClas();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}