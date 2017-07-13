using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the cosine of an angle
    /// </summary>
    public class CosCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the cosine of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }

}
 