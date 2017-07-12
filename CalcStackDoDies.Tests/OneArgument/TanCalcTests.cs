using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class TanCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(3 * Math.PI / 4, -1)]
        [TestCase(Math.PI / 4, 1)]
        public void TanCalcTest(double first, double expected)
        {
            var calc = new TanClas();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
