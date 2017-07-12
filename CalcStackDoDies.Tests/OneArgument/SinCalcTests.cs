using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class SinCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(0, Math.PI)]
        [TestCase(1, Math.PI / 2)]
        public void SinCalcTest(double first, double expected)
        {
            var calc = new SinCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
