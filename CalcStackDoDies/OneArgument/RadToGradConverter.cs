using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStackDoDies.OneArgument
{
    public class RadToGradConverter : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return first / Math.PI * 180;
        }

    }
}
