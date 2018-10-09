using System;

namespace task2
{
    class Round
    {
        public int x, y;
        public UInt32 radius;
        public double Squre { get { return Math.PI * Math.Pow(radius, 2); } }
        public double Perimeter {get { return Math.PI * radius * 2; } }
        void Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Round(int x,int y,UInt32 radius)
        {
            this.radius = radius;
            this.Point(x, y);
        }

    }
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
