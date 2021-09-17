using System;
using System.Collections.Generic;
using Comparando_Igualdade_Hash.Entities;

namespace _7_Comparando_Igualdade_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(a.Contains(prod)); //True (como classes comparam por referência, este método deveria retornar falso, porém existe um override no GetHashcode e no Equals)

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); //True (struct compara por conteúdo e não por referência)
        }
    }
}
