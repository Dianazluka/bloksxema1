using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
    public class DivCalcTests
    {
        [TestCase(4,2,2)]
        [TestCase(8,2,4)]
        [TestCase(40,0.1,400)]
        public void DivCalcTest(double first, double second, double expected)
        {
            var calc = new DivCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}

