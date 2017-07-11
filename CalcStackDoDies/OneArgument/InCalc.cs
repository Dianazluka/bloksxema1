using System;

namespace CalcStackDoDies.OneArgument
{
    public class InCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, Math.E);
        }
    }

}
 