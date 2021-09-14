using System;

namespace ProblemaMotivador2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintServiceString printService = new PrintServiceString();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} values...");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter value {i}: ");
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
