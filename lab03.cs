using System;

namespace lab03

class Program
    {

        public delegate double Operation(double x);

        public static void Main(string[] args)
        {
            Console.Write("Введiть початок вiдрiзку iнтегрування a:");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.Write("Введiть кiнець вiдрiзку iнтегрування b:");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            Console.Write("Введiть кiлькiсть дiлянок n:");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);
            Operation function = x => 5 * (Math.Sqrt(Math.Pow(x + x, 5))) -Math.Cos(x) / Math.Sin(x);
            double Intgrl = leftRectangleIntegral(a, b, n, function);
            Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] is {2: 0.0000}", a, b, Intgrl);
            Console.ReadKey();
        }

        private static double leftRectangleIntegral(double a, double b, double n, Operation function)
        {
            double d = (b - a) / n;
            double xr,i;
            double y1 = function(a);
            double y2 = function(b);
            double Intgrl = (y1 + y2) / 2;
            for (i = 1; i <= n - 1; i++)
            {
                xr = a + i * d;

                Intgrl += function(xr);
            }
            return Intgrl * d;
        }
    }
}
