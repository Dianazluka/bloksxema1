using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class LnCalcTests
    {
        [TestCase(2, 0.6931)]
        [TestCase(1, 0)]
        [TestCase(3, 1.0986)]
        public void LnCalcTest(double first, double expected)
        {
            var calc = new LnCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
        [Test]
        public void Againstzero()
        {
            var calc = new LnCalc();
            Assert.Throws<Exception>(() => calc.Calculate(-1));
        }
    }
}