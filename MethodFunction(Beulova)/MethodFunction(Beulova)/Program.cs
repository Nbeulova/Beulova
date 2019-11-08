using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFunction_Beulova_
{
    class Program
    {
        static void Main()
        {
        var x = F(5, 7) + F(12, 8) + F(31, 2);
        Console.WriteLine("x={0:F3}", x);
            Console.ReadKey();
        }
    static double F(double x, double y)
    {
        return ((x + Math.Sqrt(x)) / (y + Math.Sqrt(y)));

    }
}
}
