using System;
using task2;

namespace Task2
{
    public class Ring : Round
    {
        static private bool checkRing(uint radius1, uint radius2)
        {
            return radius1 > radius2 ? false : true;
        }
        public new uint Radius
        {
            get => base.Radius;
            set
            {
                if (!checkRing(value, ExternalRadius))
                {
                    throw new ArgumentException("internal Radius can't be larger than external");
                }
                base.Radius = value;
            }
        }
        private Round externalRound = new Round(0, 0, 0);
        public uint ExternalRadius
        {
            get => externalRound.Radius;
            set
            {
                if (!checkRing(Radius,value))
                {
                    throw new ArgumentException("External Radius can't be smaller than internal");
                }
                externalRound.Radius = value;
            }
        }
        public Ring(int x, int y, uint InternalRadius, uint ExternalRadius) : base(x, y, InternalRadius)
        {
            this.ExternalRadius = ExternalRadius;
        }
        public double RingSquare => externalRound.Square - base.Square;
        public double TwoPerimiters => externalRound.Perimeter + base.Perimeter;
    }
}
