using System;
using System.Text.RegularExpressions;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();
            input = Regex.Replace(input,@"(.*?)(<.*?>)(.*?)(<\/.*?>)(.*?)","$1_$3_$5");
            Console.Write($"\n{input}");
            Console.ReadLine();
        }
    }
}
