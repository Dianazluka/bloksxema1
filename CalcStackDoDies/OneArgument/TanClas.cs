using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the tan of an angle
    /// </summary>
    public class TanClas : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the tan of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Tan(first); 
        }
    }
}

   