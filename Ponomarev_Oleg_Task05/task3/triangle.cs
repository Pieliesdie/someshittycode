using System;

namespace task3
{
    class Triangle
    {
        public uint A { get; }
        public uint B { get; }
        public uint C { get; }

        public Triangle(uint a, uint b, uint c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                throw new Exception("it's not a triangle");
            }
        }

        public uint P()
        {
            return A + B + C;
        }

        public double S()
        {
            uint p = this.P();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

}
