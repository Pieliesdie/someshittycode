using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insert a, b");
                if (Int32.TryParse(Console.ReadLine(), out int a)
                    && a > 0
                    && Int32.TryParse(Console.ReadLine(), out int b)                   
                    && b > 0)
                {
                    Console.WriteLine($"Square - {a * b}");
                }
                else 
                {
                    Console.WriteLine($"Error");
                }
            }
        }
    }
}
