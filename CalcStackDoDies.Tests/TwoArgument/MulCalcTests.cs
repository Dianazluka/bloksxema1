using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
    public class MulCalcTests
    {
        [TestCase(4, 2, 8)]
        [TestCase(8, 2, 16)]
        [TestCase(40, 0.1, 4)]
        public void MulCalcTest(double first, double second, double expected)
        {
            var calc = new MulCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}

