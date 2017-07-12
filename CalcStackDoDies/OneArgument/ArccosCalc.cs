using System;
using System.Windows.Forms.VisualStyles;

namespace CalcStackDoDies.OneArgument
{
    /// <summary>
    /// Calculator function, finding the arc cosine of an angle
    /// </summary>
    public class ArccosCalc : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that computes the arc cosine of the angle
        /// </summary>
        /// <param name="first">Parameter that is entered by the user</param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Логарифм от 0 невозможен.");
            }
            return Math.Acos(first);
        }
    }

}
