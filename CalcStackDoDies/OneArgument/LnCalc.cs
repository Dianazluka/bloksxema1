using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function that finds the natural logarithm
    /// </summary>
    public class LnCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that computes the natural logarithm of a given number
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first, Math.E);
        }
    }

}
 