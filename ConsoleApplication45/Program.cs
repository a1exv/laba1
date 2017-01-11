using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite temperaturu v F");
            int tF = Convert.ToInt32(Console.ReadLine());
            int tC = (tF - 32) * 5 / 9;
            Console.WriteLine("t v C ={0}", tC);
        }
    }
}
