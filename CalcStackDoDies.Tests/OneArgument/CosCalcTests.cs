using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class CosCalcTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, Math.PI)]
        [TestCase(0, Math.PI / 2)]
        public void CosCalcTest(double first, double expected)
        {
            var calc = new CosCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
