using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Massives;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            if (!(Int32.TryParse(Console.ReadLine(), out int x) && Int32.TryParse(Console.ReadLine(), out int y)
                && Int32.TryParse(Console.ReadLine(), out int z)))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            int[,,] Randmassive = Massive.GetRandomMassive(x, y, z, -10, 10);
            Console.WriteLine("Исходный");
            Massive.SeeMassive(Randmassive);
            Console.WriteLine("\nПреобразованный");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        if (Randmassive[i, j, k] > 0)
                            Randmassive[i, j, k] = 0;
                    }
                }
            }
            Massive.SeeMassive(Randmassive);
            Console.ReadLine();
        }
    }
}
