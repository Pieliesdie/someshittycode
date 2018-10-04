using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static int SumRange(int startValue,int maxValue,int delta)
        {
            int last = (maxValue - maxValue % delta);
            int n = (last - startValue + delta)/delta;
            double summ = ((double)(startValue + last)) / 2 * n;
            return (int)summ;
        }

        static void Main(string[] args)
        {
            int summ = SumRange(0,999,3) + SumRange(0,999,5) - SumRange(0,999,15);
            Console.WriteLine($"Сумма чисел кратных 3 или 5 до 1000 - {summ}");
            Console.ReadKey();
        }
    }
}
