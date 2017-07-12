using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
    public class DivCalcTests
    {
        public void DivCalcTest()
        {
            double first = 3;
            double second = 2;
            var calc = new DivCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(1, result);
        }
    }
}

