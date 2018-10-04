using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert N");
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                Task2.Program.DrawChristmasTree(n,true,2);
            }
            Console.ReadKey();           
        }
    }
}
