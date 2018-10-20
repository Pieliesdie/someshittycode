using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace task3
{
    class Program
    {
        public static List<Word> GetWords(string inputString)
        {
            return Regex
                .Matches(inputString, @"\w+")
                .Cast<Match>()
                .Select(x => new Word(x.Value.ToLower(), Regex.Matches(inputString, x.Value).Count))
                .Distinct(new WordComparer())
                .OrderByDescending(x => x.Count)
                .ToList();

            //string[] words = Regex
            //    .Matches(InputString, @"\w+")
            //    .Cast<Match>()
            //    .Select(x => x.Value)
            //    .ToArray();

            //var Words = (from string word in words
            //             select new Word(word.ToLower(), Regex.Matches(InputString, word).Count))
            //           .Distinct(new WordComparer())
            //           .OrderByDescending(x => x.Count)
            //           .ToList();
        }

        static void Main(string[] args)
        {
            string input = " There there are many! big and small " +
                "libraries everywhere in our ?? country? country " +
                "They have millions of books in " +
                "different languages.";
            foreach (Word i in GetWords(input))
            {
                Console.WriteLine($"{i.Name} - {i.Count}");
            }
        }
    }
}
