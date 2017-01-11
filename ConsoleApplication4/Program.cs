using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite storoni pryamougol'nika A i B i storonu kvadrata C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < c || b < c) Console.WriteLine("Error");
            else
            {
                int counta = a / c;
                int countb = b / c;
                int count = counta * countb;
                int lefta = a % c;
                int leftb = b % c;
                int leftArea = lefta * b + leftb * a - lefta * leftb;
                Console.WriteLine("Квадратов влезет {0}, осталось площади {1}", count, leftArea);
            }
        }
    }
}
