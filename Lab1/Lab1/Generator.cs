using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Generator
    {
        public double R0 { get; protected set; }
        public double m { get; protected set; }
        public double a { get; protected set; }

        public Generator(double a, double m, double R0)
        {
            this.a = a;
            this.m = m;
            this.R0 = R0;
        }

        public IEnumerable<double> GetNext()
        {
            double prevR = R0;
            double curR;

            while (true)
            {
                curR = (a * prevR) % m;
                prevR = curR;
                yield return curR / m;
            }
        }
    }
}
