using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class MyRandom
    {
        //returns a random int, from 0.0 to max
        public int Next(int max)
        {
            return Next(0, max);
        }

        //return a random int, from min to max
        public int Next(int min, int max)
        {
            int res = (int)(DateTime.Now.Millisecond % max);
            if (res < min)
                res += min;
            if (res > max)
                res = max;
            return res;
        }
    }
}
