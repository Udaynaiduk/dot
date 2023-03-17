using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    internal class sumlimation
    {
        int weight = 100;
        public double calculate(double rate)
        {
            if (rate < 1)
            {
                throw new illegal();

            }
            return weight * rate;
                
        }
    }
}
