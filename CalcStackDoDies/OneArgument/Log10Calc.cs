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
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Логарифм от 0 невозможен.");
            }
            return Math.Log(first, 10);
        }

    }
}
