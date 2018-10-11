using System;
using task2;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring i = new Ring(3, 4, 15,6);
            i.Radius = 10;
            Console.WriteLine(i.RingSquare);
        }
    }
}
