using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введiть початкове значення X1min:");
                string sx1Min = Console.ReadLine();
                double x1Min = Double.Parse(sx1Min);
                Console.Write("Введiть кiнцеве значення X1max:");
                string sx1Max = Console.ReadLine();
                double x1Max = double.Parse(sx1Max);
                Console.Write("Введiть прирiст dX1: ");
                string sdx1 = Console.ReadLine();
                double dx1 = double.Parse(sdx1);
                Console.Write("Введiть початкове значення X2min: ");
                string sx2Min = Console.ReadLine();
                double x2Min = Double.Parse(sx2Min);
                Console.Write("Введiть кiнцеве значення X2max: ");
                string sx2Max = Console.ReadLine();
                double x2Max = double.Parse(sx2Max);
                Console.Write("Введiть прирiст dX2: ");
                string sdx2 = Console.ReadLine();
                double dx2 = double.Parse(sdx2);
                double y;
                double sum = 0.0;
                double x1 = x1Min, 
                    x2;
                for (; x1 <= x1Max; x1 += dx1)
                {
                    x2 = x2Min;
                    for (; x2 <= x2Max; x2 += dx2)
                    {
                        y = (Math.Pow(Math.Cos(Math.Log10(x1 / x2)), 2)) / (45 + x2);
                        Console.WriteLine("x1 = {0:0.0000}\tx2 = {1:0.0000}\t\ty = {2:0.0000}", x1, x2, y); 
                        if(y > 0)
                        {
                            sum += y;
                        }

                    }
                Console.WriteLine("result = {0:0.000}", sum);
                    Console.ReadKey();


                }
            }
        }
    }
