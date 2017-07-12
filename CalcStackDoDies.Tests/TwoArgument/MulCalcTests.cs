using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
    public class MulCalcTests
    {
        public void MulCalcTest()
        {
            double first = 3;
            double second = 2;
            var calc = new MulCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(1, result);
        }
    }
}

