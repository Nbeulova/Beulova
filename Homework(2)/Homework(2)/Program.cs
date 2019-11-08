using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Input("x");
            var y = Input("y");
            Console.WriteLine("Значение выражения" + F(x, y));
            Console.ReadKey();

        }
        static bool F(double x, double y)
        {
           
            return (x % 3 == 0 | y % 2 == 0);

        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите число " + Name);
            return double.Parse(Console.ReadLine());
        }
    }
}
