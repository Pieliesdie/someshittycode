using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Massives;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            if (!(Int32.TryParse(Console.ReadLine(), out int y) && Int32.TryParse(Console.ReadLine(), out int x)))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            int[,] randmass = Massive.GetRandomMassive(x, y, 1, 30);
            Massive.SeeMassive(randmass);
            Console.Write($"\n");
            int summ = 0, row = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = row; j < y; j += 2)
                {
                    Console.Write($"{randmass[i, j]} ");
                    summ += randmass[i, j];
                }
                if (row == 1)
                {
                    row = 0;
                }
                else
                {
                    row = 1;
                }
            }
            Console.WriteLine($"\nsumm - {summ}");
            Console.ReadKey();
        }
    }
}
