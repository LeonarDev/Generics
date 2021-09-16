using System;

namespace _1_ProblemaMotivador1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} values...");

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Enter value {i}: ");
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
