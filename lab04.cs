using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Program
    {
            const double StartX = 10.3;
            const double dX = 0.7;

            static double Function(double x)
            {
                double x1 = 2.76 * x;
                double x2 = 0.5 * x;
                return (Math.Pow(Math.Cos(x1 + 2 * x2 + 9 / 0.666), 3) + Math.Pow(x2, 7));
            }
            static void Main(string[] args)
            {
                double[] arr = new double[10];
                double x = StartX;


                for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
                {

                    arr[i] = Function(x); x += dX;

                }
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine("Вiдсортованiза спаданням значення масиву: ");
                for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
                {
                    Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
                }
            double aMin = arr[arr.GetUpperBound(0)];
            double aMax = arr[arr.GetLowerBound(0)];
            double aAvg = arr.Average();
            double qua = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > aAvg)
                {
                    qua += 1;
                }
            }
            Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
            Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
            Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
            Console.WriteLine("Кількість елементів масиву: {0:0.0000}", qua);
            Console.ReadKey(true);

        }
        }
}
