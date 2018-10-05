using Massives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            if (!(Int32.TryParse(Console.ReadLine(), out int n)))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            int[] rand = Massive.GetRandomMassive(n, -10, 10);
            Massive.SeeMassive(rand);
            int summ = 0;
            foreach (int i in rand)
            {
                if (i > 0)
                {
                    summ += i;
                }
            }
            Console.WriteLine($"summ - {summ}");
            Console.ReadKey();
        }
    }
}
