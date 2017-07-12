using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class CosCalcTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI, -1)]
        [TestCase(Math.PI / 2, 0)]
        public void CosCalcTest(double first, double expected)
        {
            var calc = new CosCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
