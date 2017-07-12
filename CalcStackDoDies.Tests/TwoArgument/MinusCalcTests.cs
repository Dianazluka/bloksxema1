using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
    public class MinusCalcTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(8, 2, 6)]
        [TestCase(40, 0.1, 39.9)]
        public void MinusCalcTest(double first, double second, double expected)
        {
            var calc = new MinusCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}

