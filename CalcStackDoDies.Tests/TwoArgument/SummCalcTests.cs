using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
     public class  SummCalcTests
    {
        [TestCase(4, 2, 6)]
        [TestCase(8, 2, 10)]
        [TestCase(40, 0.1, 40.1)]
        public void SummCalcTest(double first, double second, double expected)
        {
            var calc = new SummCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
