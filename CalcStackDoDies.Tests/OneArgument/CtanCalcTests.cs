using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class CtanCalcTests
    {
        [TestCase(3 * Math.PI / 2, 0)]
        [TestCase(Math.PI / 4, 1)]
        [TestCase(3 * Math.PI / 4, -1)]
        public void CtanCalcTest(double first, double expected)
        {
            var calc = new CtanCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
