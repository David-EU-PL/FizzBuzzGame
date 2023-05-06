using System;

namespace FizzBuzzGame
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Witaj w prostej grze FizzBuzz. \nPodając liczbę sprawdzimy czy jest podzielna przez 3 bez reszty i/lub przez 5 bez reszty albo nie nie spełnia obu warunków. \nPodaj proszę dowolną liczbę: ");
            var number = GetNumber();
            
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("\nFizzBuzz");
            }
            else
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("\nFizz");
                }
                if (number % 5 == 0)
                {
                    Console.WriteLine("\nBuzz");
                }
            }
            return number;
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę. Możesz spróbować ponownie.\n");
                    continue;
                }
                return number;
            }
        }
    }
}

