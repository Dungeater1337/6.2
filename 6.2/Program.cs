using System;
using System.Net.NetworkInformation;

namespace uppgift6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ett till tal");
            int tal2 = int.Parse(Console.ReadLine());

            int Största = Störst( tal1, tal2);
            Console.WriteLine("Det största talet är " + Största);
        }

        static int Störst(int tal1, int tal2)
        {

            if (tal1 == tal2)
            {
                return tal1 + tal2;
            }

            else if (tal1 < tal2)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }

    }
}