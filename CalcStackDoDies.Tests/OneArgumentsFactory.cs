using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests
{
    [TestFixture]
    public class OneArgumentsFactoryTests
    {
        [TestCase("Exp", typeof(ExpCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
