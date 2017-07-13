using System;

namespace CalcStackDoDies.TwoArgument
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// The method returns an instance of the class ITwoArgumentsCalculator
        /// </summary>
        /// <param name="calculatorName">calculator name</param>
        /// <returns>instance of the class</returns>
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Plus":
                    return new SummCalc();
                case "Minus":
                    return new MinusCalc();
                case "Mul":
                    return new MulCalc();
                case "Div":
                    return new DivCalc();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}