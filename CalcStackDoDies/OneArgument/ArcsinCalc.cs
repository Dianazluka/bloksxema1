using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the arc sine of an angle
    /// </summary>
    public class ArcsinCalc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the arc sine of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }

}
 