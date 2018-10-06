using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> stringbuilder = new List<long>();
            List<long> _string = new List<long>();
            for (int k = 0; k < 1000; k++)
            {
                string str = "";
                StringBuilder sb = new StringBuilder();
                int N = 100;
                var watch = Stopwatch.StartNew();
                for (int i = 0; i < N; i++)
                {
                    str += "*";
                }
                watch.Stop();
                stringbuilder.Add(watch.ElapsedTicks);
                watch.Restart();
                for (int i = 0; i < N; i++)
                {
                    sb.Append("*");
                }
                watch.Stop();
                _string.Add(watch.ElapsedTicks);
            }
            double a = stringbuilder.Average();
            double b = _string.Average();
            if (a > b)
                Console.WriteLine($"string лучше в {Convert.ToInt32((a / b))} раз");
            else
                Console.WriteLine($"stringbuilder лучше в {Convert.ToInt32((b / a))} раз");
            Console.ReadKey();
        }
    }
}
