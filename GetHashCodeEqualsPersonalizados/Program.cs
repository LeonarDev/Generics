using GetHashCodeEqualsPersonalizados.Entities;
using System;

namespace _5_GetHashCodeEqualsPersonalizados
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@email.com" };
            Client b = new Client { Name = "Alex", Email = "alex@email.com" };
            Client c = new Client { Name = "Copy", Email = "alex@email.com" };

            Console.WriteLine(a.Equals(b)); // False
            Console.WriteLine(a == b); // False
            Console.WriteLine(b == c); // False (even with the "email" content being the same, the memory reference is different)
            Console.WriteLine(a.GetHashCode()); // -137047242
            Console.WriteLine(b.GetHashCode()); // 685467384
        }
    }
}
