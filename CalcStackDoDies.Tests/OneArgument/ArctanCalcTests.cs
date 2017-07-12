using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class AcrtanCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(0, Math.PI)]
        [TestCase(1, Math.PI / 4)]
        public void CosCalcTest(double first, double expected)
        {
            var calc = new ArctanCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
