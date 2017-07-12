using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class CosgradCalcTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, 180)]
        [TestCase(0, 90)]
        public void ArcsingradCalcTest(double first, double expected)
        {
            var calc = new CosgradClas();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}