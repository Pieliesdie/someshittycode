using System;
using task2;

namespace Task2
{
    public class Ring : Round
    {
        static private void checkRing(uint radius1, uint radius2)
        {
            if( radius1 > radius2 )
                throw new ArgumentException("External Radius can't be smaller than internal");
        }
        public new uint Radius
        {
            get => base.Radius;
            set
            {
                checkRing(value, ExternalRadius);
                base.Radius = value;
            }
        }
        private Round externalRound = new Round(0, 0, 0);
        public uint ExternalRadius
        {
            get => externalRound.Radius;
            set
            {
                checkRing(Radius, value);
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
