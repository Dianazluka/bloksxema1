using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function that finds the number module
    /// </summary>
    public class ModulCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that calculates the number module
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
