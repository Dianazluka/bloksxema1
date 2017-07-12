using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function that finds the decimal logarithm
    /// </summary>
    public class Log10Calc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that computes the decimal logarithm of a given number
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}
