using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class CtanCalcTests
    {
        [TestCase(0, 3/2*Math.PI)]
        [TestCase(1, Math.PI/4)]
        [TestCase(0, Math.PI / 2)]
        public void CtanCalcTest(double first, double expected)
        {
            var calc = new CtanCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
