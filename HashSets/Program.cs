using System;
using System.Collections.Generic;

namespace _6_HashSetsESortedSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("Computer"));
            Console.WriteLine();

            foreach(string str in set)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.Write("a: ");
            PrintCollection(a);

            Console.Write("b: ");
            PrintCollection(b);

            Console.WriteLine();
            // union
            Console.WriteLine("a union b");
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("c: ");
            PrintCollection(c);

            Console.WriteLine();
            // intersection
            Console.WriteLine("a intersection b");
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("d: ");
            PrintCollection(d);

            Console.WriteLine();
            // difference
            Console.WriteLine("a difference b");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("e: ");
            PrintCollection(e);

            Console.WriteLine();
            SortedSet<int> f = new SortedSet<int>(b);
            Console.WriteLine("b difference a");
            f.ExceptWith(a);
            Console.Write("f: ");
            PrintCollection(f);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
