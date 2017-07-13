using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Function calculator, raising the number two to a given degree
    /// </summary>
    public class TwoinxCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// A method that calculates a given power of the number two
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}
