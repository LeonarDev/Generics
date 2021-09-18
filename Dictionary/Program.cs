using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@email.com";
            cookies["phone"] = "912345678";

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");
            Console.WriteLine();

            Console.WriteLine("ALL COOKIES:");
            //foreach(KeyValuePair<string, string> item in cookies)
            foreach(var item in cookies) //declaração menos verbosa
                {
                Console.WriteLine(item);
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
