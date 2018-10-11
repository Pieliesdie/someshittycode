using System;

namespace task2
{
    public class Round
    {
        public int x, y;
        public UInt32 Radius;
        public double Square => Math.PI * Math.Pow(Radius, 2);
        public double Perimeter => Math.PI * Radius * 2;
        private void Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Round(int x, int y, UInt32 radius)
        {
            this.Radius = radius;
            this.Point(x, y);
        }
    }
}
