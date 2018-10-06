using System;
using System.Text.RegularExpressions;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();
            input = Regex.Matches(input,@"(.*?)(\b[0,1][0-9]|2[0-3][:][0-5][0-9]\b)(.*?)").Count.ToString();
            Console.Write($"\n{input}");
            Console.ReadLine();
        }
    }
}
