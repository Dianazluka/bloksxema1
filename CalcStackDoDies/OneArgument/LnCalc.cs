using System;

namespace CalcStackDoDies.OneArgument
{
    public class LnCalc : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, Math.E);
        }
    }

}
 