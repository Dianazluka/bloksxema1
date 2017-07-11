using System;

namespace CalcStackDoDies.OneArgument
{
    public class Log2Calc : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 2);
        }
    }

}
 