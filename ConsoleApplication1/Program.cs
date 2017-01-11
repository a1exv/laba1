using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite koordinati 3 tochek");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());
            double a=Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            double p = a + b + c;
            double halfp = p / 2;
            double s = Math.Sqrt(halfp * (halfp - a) * (halfp - b) * (halfp - c));
            Console.WriteLine("Perimetr = {0},  Area= {1}", p, s);
        }
    }
}
