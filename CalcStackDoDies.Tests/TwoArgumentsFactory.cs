using System;
using CalcStackDoDies.TwoArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests
{
    [TestFixture]
    public class MulCalcTests
    {
        [TestCase("Mul", typeof(MulCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class DivCalcTests
    {
        [TestCase("Div", typeof(DivCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class MinusCalcTests
    {
        [TestCase("Minus", typeof(MinusCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class SummCalcTests
    {
        [TestCase("Plus", typeof(SummCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}