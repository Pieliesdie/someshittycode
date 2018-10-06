using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static string DoubleUp(string input, string input2)
        {
            List<char> cashe = new List<char>();
            foreach (char i in input2)
            {
                if (!cashe.Contains(i))
                {
                    cashe.Add(i);
                    input = Regex.Replace(input, $"{i}", $"{i}{i}");
                }
            }
            return input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 строки для удваивания в " +
                "первой введенной строке все символы, принадлежащие второй " +
                "введенной строке слов");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine().Replace(" ","");
            Console.WriteLine(DoubleUp(input1, input2));
            Console.ReadKey();
        }
    }
}
