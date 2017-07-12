using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class ModulCalcTests
    {
        [TestCase(1, 1)]
        [TestCase(-5, 5)]
        [TestCase(16, 16)]
        public void ModulCalcTest(double first, double expected)
        {
            var calc = new ModulCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}