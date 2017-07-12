using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function that finds the base logarithm two
    /// </summary>
    public class Log2Calc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that computes the base logarithm two of a given number
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first, 2);
        }
    }

}
 