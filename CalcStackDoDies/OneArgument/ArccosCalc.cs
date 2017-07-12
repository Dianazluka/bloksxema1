using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the arc cosine of an angle
    /// </summary>
    public class ArccosCalc : OneArgument.IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the arc cosine of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }

}
