using System;

namespace CalcStackDoDies.OneArgument
{
    public static class OneArgumentsFactory
    {
        /// <summary>
        /// The method returns an instance of the class IOneArgumentsCalculator
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns>instance of the class</returns>
        public static IOneArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new SinCalc();
                case "Cos":
                    return new CosCalc();
                case "Tan":
                    return new TanClas();
                case "Ctan":
                    return new CtanCalc();
                case "Exp":
                    return new ExpCalc();
                case "In":
                    return new LnCalc();
                case "Sqr":
                    return new SqrCalc();
                case "Twoinx":
                    return new TwoinxCalc();
                case "Modul":
                    return new ModulCalc();
                case "Onedivx":
                    return new OnedivxCalc();
                case "Arccos":
                    return new ArccosCalc();
                case "Arcsin":
                    return new ArcsinCalc();
                case "Arcsingrad":
                    return new ArcsingradCalc();
                case "Arctan":
                    return new ArctanCalc();
                case "Cosgrad":
                    return new CosgradClas();
                case "Log10":
                    return new Log10Calc();
                case "Log2":
                    return new Log2Calc();
                case "Mimus":
                    return new MinusxCalc();
                case "Singrad":
                    return new SingradCalc();
                case "Teninx":
                    return new TwoinxCalc();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}