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
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Логарифм от 0 невозможен.");
            }

            return Math.Log(first, Math.E);
        }
    }

}
 