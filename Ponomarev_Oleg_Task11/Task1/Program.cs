using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            long i =TaskMath.Factorial(3);
            for(int k = 0; k < 10; k++)
            {
                Console.WriteLine(TaskMath.Pow(2,k));
            }
            Console.WriteLine(i.ToString());
        }
    }
}
