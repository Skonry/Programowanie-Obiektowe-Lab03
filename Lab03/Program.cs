using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Ala ma kota bo sierotka ma ryśa";

            Dictionary<int, List<string>> words = new();

            foreach(var word in text.Split(" "))
            {
                int wordLength = word.Length;

                if (!words.ContainsKey(wordLength))
                {
                    words.Add(wordLength, new List<string>());
                }

                words[wordLength].Add(word);
            }

            foreach (var entry in words)
            {
                Console.WriteLine($"{entry.Value.Count} - {String.Join("; ", entry.Value)}");
            }

            foreach(var word in text.Split(" "))
            {
                Console.WriteLine(word.ToUpper());
            }

            text.Split(" ").Select(word => word.ToUpper()).ToList().ForEach(word => Console.WriteLine(word));

            int[] intTable = { 4, 2, 6, 2, 1, 5, 7, 2, 34, 6};

            intTable.Select(x => x * 2).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            intTable.Where(x => x > 4).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            intTable
                .Where(x => x > 4)
                .Select(x => x * 2)
                .OrderByDescending(x => x)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            text.Split(" ")
                .GroupBy(x => x.Length)
                .OrderBy(x => x.Key)
                .ToList()
                .ForEach(x => Console.WriteLine(String.Join("; ", x)));
        }
    }
}
