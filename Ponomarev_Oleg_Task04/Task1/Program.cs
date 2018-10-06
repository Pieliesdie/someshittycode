using System;
using System.Linq;

namespace Task1
{
    static 
    class Program
    {
        //static readonly char[] punctuation = new char[] {',' , '?' , '!' , '.' , ':' , ';' , '-', ' '};
        static string RemovePunctuation(string input)
        {
            foreach (char i in input)
            {
                if (char.IsPunctuation(i))
                {
                    input = input.Replace(i, ' ');
                }
            }
            return input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для подсчета среднего колличества слов");
            string input = Console.ReadLine();
            input = RemovePunctuation(input);
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double average = words.Average(x => x.Count());
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
