using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class Distributions
    {
        public static List<double> Uniform(IEnumerable<double> values, double a, double b)
        {
            List<double> list = new List<double>();

            foreach(double R in values)
            {
                list.Add(a + (b - a) * R);
            }

            return list;
        }

        public static List<double> Gauss(IEnumerable<double> values, double m, double sigma)
        {
            List<double> list = new List<double>();
            Random rand = new Random();
            double[] array = values.ToArray();

            for (int i = 0; i<100000;i++)
            {
                double sum = 0;

                for (int j = 0; j < 6; j++)
                {
                    int index = rand.Next(1, 99999);
                    sum += array[index];
                }

                list.Add(m + sigma * Math.Sqrt(2) * (sum - 3));
            }

            return list;
        }

        public static List<double> Exponential(IEnumerable<double> values, double lambda)
        {
            List<double> list = new List<double>();

            foreach (double R in values)
            {
                list.Add(-1*(Math.Log(R)) / lambda);
            }

            return list;
        }

        public static List<double> Gamma(IEnumerable<double> values, double lambda, int n)
        {
            List<double> list = new List<double>();
            Random rand = new Random();
            double[] array = values.ToArray();

            for (int i = 0; i < 100000; i++)
            {
                double mult = 1;

                for (int j = 0; j < n; j++)
                {
                    int index = rand.Next(1, 99999);
                    mult *= array[index];
                }

                list.Add(-1 * (Math.Log(mult)) / lambda);
            }

            return list;
        }

        public static List<double> Triangle(IEnumerable<double> values, double a, double b)
        {
            List<double> list = new List<double>();
            double[] array = values.ToArray();

            for (int i =0; i<array.Length; i += 2)
            {
                //if (array[i + 1] < array[i])
                {
                    list.Add(a + (b - a) * Math.Max(array[i], array[i + 1]));
                }
            }

            return list;
        }

        public static List<double> Simpson(IEnumerable<double> values, double a, double b)
        {
            List<double> list = new List<double>();
            List<double> uniformList = Distributions.Uniform(values, a / 2, b / 2);
            Random rand = new Random();

            for (int i = 0; i < 100000; i++)
            {
                int index1 = rand.Next(1, 99999);
                int index2 = rand.Next(1, 99999);

                list.Add(uniformList[index1] + uniformList[index2]);
            }

            return list;
        }
    }
}
