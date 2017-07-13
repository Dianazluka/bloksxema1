using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests
{
    [TestFixture]
    public class ArccosCalcTesrs
    {
        [TestCase("Arccos", typeof(ArccosCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class ArcsinCalcTesrs
    {
        [TestCase("Arcsin", typeof(ArcsinCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class ArcsingradCalcTesrs
    {
        [TestCase("Arcsingrad", typeof(ArcsingradCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class ArctanCalcTesrs
    {
        [TestCase("Arctan", typeof(ArctanCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class CosCalcTesrs
    {
        [TestCase("Cos", typeof(CosCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class CosgradClasTesrs
    {
        [TestCase("Cosgrad", typeof(CosgradClas))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class СtanCalcTesrs
    {
        [TestCase("Ctan", typeof(CtanCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class ExpCalcTesrs
    {
        [TestCase("Exp", typeof(ExpCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class LnCalcTesrs
    {
        [TestCase("Ln", typeof(LnCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class Log10CalcTesrs
    {
        [TestCase("Log10", typeof(Log10Calc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class Log2CalcTesrs
    {
        [TestCase("Log2", typeof(Log2Calc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class MinusxCalcTesrs
    {
        [TestCase("Minusx", typeof(MinusxCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class ModulCalcTesrs
    {
        [TestCase("Modul", typeof(ModulCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class OnedivxCalcTesrs
    {
        [TestCase("Onedivx", typeof(OnedivxCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class SinCalcTesrs
    {
        [TestCase("Sin", typeof(SinCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class SingradCalcTesrs
    {
        [TestCase("Singrad", typeof(SingradCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class SqrCalcTesrs
    {
        [TestCase("Sqr", typeof(SqrCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class TanCalcTesrs
    {
        [TestCase("Tan", typeof(TanClas))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class TeninxCalcTesrs
    {
        [TestCase("Teninx", typeof(TeninxCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
    [TestFixture]
    public class TwoinxCalcTesrs
    {
        [TestCase("Twoinx", typeof(TwoinxCalc))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
 }
