using System;

namespace CalcStackDoDies
{
    public static class TwoArgumentsFactory
    {
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