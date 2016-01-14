using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class MyRandom
    {
        //returns a random double, from 0.0 to max
        public double Next(double max)
        {
            return Next(0.0, max);
        }

        //round n in the mathematical way 
        private int Round(double n)
        {
            int res = (int)n; //8.5 => 8, 8.3 => 8
            if (n - Math.Truncate(n) > 0.5) //8.8 => 9
                res++;
            return res;
        }

        //return a random double, from min to max
        public double Next(double min, double max)
        {
            double res = (double)(DateTime.Now.Millisecond % Round(max)); //with max as double you could get error because of memory represention of result. So (int) max is needed
            if (res < min)
                res += min;
            if (res > max)
                res = max;
            return res;
        }
    }
}
