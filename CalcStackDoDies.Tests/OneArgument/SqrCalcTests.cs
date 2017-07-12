using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class SqrCalcTests
    {
        [TestCase(2,4)]
        [TestCase(-5, 25)]
        [TestCase(0, 0)]
        public void SqrCalcTest(double first, double expected)
        {
            var calc = new SqrCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}