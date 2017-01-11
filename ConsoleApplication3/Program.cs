using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число от 100 до 999");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 100 && number < 999)
            {
                String[] sotni = new String[9] { "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };
                String[] desyatki = new String[9] { "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто " };
                String[] nadcat = new String[9] { "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                String[] edin = new String[9] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
                int sto = number / 100;
                number = number % 100;
                Console.Write(sotni[sto - 1]);
                if (number > 19)
                {
                    int desyat = number / 10;
                    Console.Write(desyatki[desyat - 1]);
                    number = number % 10;
                    if (number > 0)
                    {
                        Console.Write(edin[number - 1]);
                    }
                }
                else if (number > 10 && number < 20)
                {
                    number = number % 10;
                    Console.Write(nadcat[number - 1]);
                }
                else if (number == 10)
                {
                    Console.Write(desyatki[0]);
                }
                else if (number == 0) { }
                else Console.Write(edin[number - 1]);
                Console.WriteLine("\n");
            }
            else Console.WriteLine("Nevernoe chislo!");
        }
    }
}
