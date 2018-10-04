using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert N");
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= n+1; i++)
                {
                    Task2.Program.DrawChristmasTree(i,false,2, n+1);
                }
            }
            Console.ReadKey();
        }
    }
}
