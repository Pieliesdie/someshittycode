using System;
using System.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100000000];
            int index = 0;
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    int tmp = new TwoDPointWithHash(i, j).GetHashCode();
                    array[index] = tmp;
                    index++;
                }
            }
            System.Console.WriteLine(array.Distinct().Count()+ $" from {10000*10}");
            Console.ReadLine();
        }
    }
}
