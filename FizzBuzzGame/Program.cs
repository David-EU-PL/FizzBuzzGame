using System;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w prostej grze FizzBuzz. \nPodając liczbę sprawdzimy czy jest podzielna przez 3 bez reszty 'Fizz' lub przez 5 bez reszty 'Buzz'albo spełnia oba warunki 'FizzBuzz'. \nW przeciwnym wypadku liczba zostanie zwrócona.");
            var fizzBuzz = new FizzBuzz();

            while (true)
            {
                Console.WriteLine("\nPodaj proszę dowolną liczbę: ");
                var number = GetNumber();
                Console.WriteLine(fizzBuzz.GetOutput(number));
                Console.WriteLine();
            }
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

