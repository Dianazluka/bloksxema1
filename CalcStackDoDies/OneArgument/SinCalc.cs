using System;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the sine of an angle
    /// </summary>
    public class SinCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the sine of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }

}