using System;

namespace lab01
{
    class Program
    {
        public static double Foo(double x1, double x2) => Math.Pow(Math.Sin(((x1 * x2) / (x1 + 53 * Math.Pow(x2, 2)))), 2);

        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення Xmin:");
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);
            Console.Write("Введiть кiнцеве значення Xmax:");
            string sxMax = Console.ReadLine();
            double xMax = double.Parse(sxMax);
            Console.Write("Введiть прирiст dX: ");
            string sdx = Console.ReadLine();
            double dx = double.Parse(sdx);
            double x1 = xMin;
            double x2 = 0;
            double y;
            double res = 1;
            while (x1 <= xMax)
            {
                x2 = 3 * x1;
                y = Math.Pow(Math.Sin((x1 * x2 / (x1 + 53 * Math.Pow(x2, 2)))), 2);
                if (x1 > xMin && x1 < xMax)
                {
                    res += Math.Cos(y);
                }
                Console.WriteLine("x1 = {0} x2={1} \t\t\t\t y = {2}, p = {3}", x1, x2, y, res);
                x1 += dx;

            }
            if (Math.Abs(x1 - xMax - dx) > 0.0001)
            {
                y = Math.Pow(Math.Sin((x1 * x2 / (x1 + 53 * Math.Pow(x2, 2)))), 2);
                Console.WriteLine("x1 = {0}\t\t y = {1}", x1, x2);
                Console.ReadKey();
            }
        }
    }
}
