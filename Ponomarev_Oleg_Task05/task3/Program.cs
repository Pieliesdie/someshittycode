using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(3, 4, 5);
            Console.WriteLine(tri.P());
            Console.WriteLine(Math.Round(tri.S(),3));
            Console.ReadKey();
        }
    }
}
