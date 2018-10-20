using System;
using Task1;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] w = new int[] { 1, 2, 3, 4, 5 };
            DinamicArray<int> i = new DinamicArray<int>(w);
            foreach(int q in i)
            {
                Console.WriteLine(q);
            }
        }
    }
}
