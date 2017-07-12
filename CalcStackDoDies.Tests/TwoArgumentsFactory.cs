using System;
using CalcStackDoDies.OneArgument;
using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests
{
    [TestFixture]
    public class TwoArgumentsFactoryTests
    {
        [TestCase("Mul", typeof(MulCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}