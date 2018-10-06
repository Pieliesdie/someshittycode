using System;
using System.Text.RegularExpressions;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите текст: ");
                string input = Console.ReadLine();
                bool? format = null;
                if (Regex.Matches(input, @"^\s*[-]?\d+(([.]\d+)|(\d*))e[-]\d+$").Count == 1)
                {
                    format = true;
                }
                if (Regex.Matches(input, @"^\s*[-]?\d+(([.]\d+)|(\d*))+$").Count == 1)
                {
                    format = false;
                }
                switch (format)
                {
                    case true:
                        Console.WriteLine("Это число в научной нотации");
                        break;
                    case false:
                        Console.WriteLine("Это число в обычной нотации");
                        break;
                    default:
                        Console.WriteLine("Это не число");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
