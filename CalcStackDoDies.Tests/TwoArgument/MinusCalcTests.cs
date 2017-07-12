using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
    public class MinusCalcTests
    {
        public void MiusCalcTest()
        {
            double first = 3;
            double second = 2;
            var calc = new MinusCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(1, result);
        }
    }
}

