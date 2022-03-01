using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading;

namespace Task01_Queue
{
    class Program
    {
        private static readonly Random _random = new();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //your code here.
        }

        private static void Generate()
        {
            //your coed here.
        }

        private static void Process()
        {
            //your code here.
        }

        private static double GetIntegral(double x)
        {
            double step = 0.0000001;

            double sum = 0;
            double start = 0;
            while (x - start > step)
            {
                sum += 0.5 * (F(start) + F(start + step)) * step;
                start += step;
            }

            return sum / Math.Sqrt(2 * Math.PI);
        }

        private static double F(double x)
        {
            return Math.Exp(-(x * x) / 2);
        }
    }
}