using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());
            double length = ((2 * Math.PI) * r);
            double square = (Math.PI * (r * r));
            Console.WriteLine("Длинна окружности равна: {0}, площадь: {1}", length, square);
            Console.ReadKey();
        }
    }
}

