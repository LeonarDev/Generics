using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }

                        foreach (var item in dictionary)
                        {
                            Console.WriteLine(item.Key + ": " + item.Value);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
