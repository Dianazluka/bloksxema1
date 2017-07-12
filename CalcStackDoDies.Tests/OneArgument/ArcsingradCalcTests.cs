using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class ArcsingradCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(0, 180)]
        [TestCase(1, 90)]
        public void ArcsingradCalcTest(double first, double expected)
        {
            var calc = new ArcsingradCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}