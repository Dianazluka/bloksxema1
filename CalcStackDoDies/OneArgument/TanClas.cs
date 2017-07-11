using System;

namespace CalcStackDoDies.OneArgument
{
    public class TanClas : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first); 
        }
    }
}

   