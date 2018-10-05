using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Massives;

namespace task1
{
    public class Program
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
            int[] RandomMassive = Massive.GetRandomMassive(n, -10, 10);
            Massive.SeeMassive(RandomMassive);
            Massive.BubbleSort(RandomMassive);
            Console.WriteLine();
            Massive.SeeMassive(RandomMassive);
            int MaxValue = 0;
            int MinValue = 0;
            if (RandomMassive.Length > 0)
            {
                MaxValue = RandomMassive[RandomMassive.Length - 1];
                MinValue = RandomMassive[0];
            }
            Console.WriteLine($"\nMaxValue - {MaxValue}\nMinValue - {MinValue}");
            Console.ReadKey();
        }
    }
}
