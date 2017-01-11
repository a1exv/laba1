using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Initial = 1000;
            Console.WriteLine("Vvedite procent");
            int stavka = Convert.ToInt32(Console.ReadLine());
            int K=0;
            while (Initial < 1100)
            {
                Initial = Initial+Initial * stavka / 100;
                K++;
            }
            Console.WriteLine("Razmer vklada = {0} cherez {1} mes.", Initial, K);
        }
    }
}
