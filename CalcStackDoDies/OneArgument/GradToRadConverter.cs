using System;

namespace CalcStackDoDies.OneArgument
{
    public class GradToRadConverter : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that translates from degrees to radians
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return first * Math.PI / 180;
        }
    }
}