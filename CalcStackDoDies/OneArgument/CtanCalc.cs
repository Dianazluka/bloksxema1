using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the cotan of an angle
    /// </summary>
    public class CtanCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the cotan of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return 1 / Math.Tan(first);
        }
    }

}
