using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Beulova_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х");
            double X = double.Parse(Console.ReadLine());
            double Y = (X + (2 + Math.Cos(X) / (X * X))) / (X + (1 / (Math.Sqrt((X * X) + 10))));
            Console.WriteLine("Y = {0}", Y);
            Console.ReadKey();
        }
    }
}
