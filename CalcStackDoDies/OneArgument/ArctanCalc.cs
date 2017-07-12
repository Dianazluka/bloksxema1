using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the arc tang of an angle
    /// </summary>
    public class ArctanCalc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the arc tang of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
