using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Function that finds a quotient of a unit by a given number
    /// </summary>
    public class OnedivxCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that calculates the quotient of a unit by a given number
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            if (first.Equals(0))
            {
                throw new Exception("Деление на 0 невозможно.");
            }
            return 1 /first;
        }
    }
}
