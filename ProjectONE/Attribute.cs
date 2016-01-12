using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class Attribute
    {
        public enum AttributeType { STRING, DOUBLE, INT };
        String Name { get; set; }
        AttributeType type { get; }
        double upperbound { get; set; }
        double lowerbound { get; set; }
        int value_int { get; set; }
        double value_double { get; set; }
        string value_string { get; set; }

        /**
         * Note: if t = STRING => lb and ub are excluded automatically
         */
        public Attribute(String name, AttributeType t, double lb, double ub)
        {
            this.Name = name;
            this.type = t;
            if (t != AttributeType.STRING)
            {
                this.upperbound = ub;
                this.lowerbound = lb;
            }
        }

        public override string ToString()
        {
            string ris = Name + ":" + this.type + "[" + this.lowerbound + ";" + this.upperbound + "] ";
            switch(type)
            {
                case AttributeType.DOUBLE:
                    ris += value_double;
                    break;
                case AttributeType.INT:
                    ris += value_int;
                    break;
                case AttributeType.STRING:
                    ris += value_string;
                    break;
            }
            return ris;
        }

        public Attribute Clone()
        {
            return new Attribute(Name, type, this.lowerbound, this.upperbound);
        }

        public Attribute generate()
        {
            MyRandom r = new MyRandom();
            switch (type)
            {
                case AttributeType.STRING:
                    string a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    value_string = a[(int)r.Next(49)].ToString();
                    value_string += a[(int)r.Next(6, 26)];
                    value_string += a[(int)r.Next(9, 18)];
                    value_string += a[(int)r.Next(25,48)];
                    break;
                case AttributeType.INT:
                    value_int = (int)r.Next(this.lowerbound, this.upperbound);
                    break;
                case AttributeType.DOUBLE:
                    value_double = r.Next(this.lowerbound, this.upperbound);
                    break;
            }
            return this;
        }
        
    }

    public class MyRandom
    {
        public double Next(double max)
        {
            return Next(0.0, max);
        }

        private int Round(double n)
        {
            int res = (int)n;
            if (n - Math.Truncate(n) > 0.5)
                res++;
            return res;
        }

        public double Next(double min, double max)
        {
            double res = (double) (DateTime.Now.Millisecond % Round(max)); //with max as double you could get error because of memory represention of result. So (int) max is needed
            if (res < min)
                res += min;
            if (res > max)
                res = max;
            return res;
        }
    }

}
