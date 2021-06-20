using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfNumberIsEven
{
    class Program
    {
        private static int GetNumber()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int givenNumber))
                {
                    Console.WriteLine("\nPodałeś błędne dane, podaj liczbę całkowitą!\n");
                    continue;
                }

                return givenNumber;

            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nCześć, podaj mi liczbę całkowitą, a sprawdzę czy jest parzysta.\n");
            if (GetNumber() % 2 == 0)
            {
                Console.WriteLine("\nTwoja liczba jest parzysta!\n");
            }
            else
            Console.WriteLine("\nTwoja liczba jest nieparzysta.\n");
        }
    }
}
