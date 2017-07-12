using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStackDoDies.OneArgument
{
    public class RadToGradConverter : IOneArgumentsCalculator
    {
        /// <summary>
        /// Method that translates from radians to degrees
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return first / Math.PI * 180;
        }

    }
}
