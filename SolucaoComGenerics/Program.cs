using System;

namespace _3_SolucaoComGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} values...");

            for (int i = 1; i <= n; i++)
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
