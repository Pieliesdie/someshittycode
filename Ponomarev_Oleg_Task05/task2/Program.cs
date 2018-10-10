using System;

namespace task2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round(5, 3, 6);
            Console.WriteLine(round.radius);
            Console.WriteLine(Math.Round(round.Squre,3));
            Console.WriteLine(Math.Round(round.Perimeter, 3));
            Console.ReadKey();
        }
    }
}
