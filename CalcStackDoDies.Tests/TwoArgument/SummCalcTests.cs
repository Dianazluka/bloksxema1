using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.TwoArgument
{
    [TestFixture]
     public class  SummCalcTests
    {
        public void SummCalcTest()
        {
            double first = 2;
            double second = 2;
            var calc = new SummCalc();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(4, result);
        }
    }
}
