using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class SingradCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(270, -1)]
        [TestCase(90, 1)]
        public void SingradCalcTest(double first, double expected)
        {
            var calc = new SingradCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}