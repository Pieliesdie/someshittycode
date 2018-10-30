namespace task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            int tmp = this.x << 16;
            tmp = tmp | this.y;
            return tmp;
        }
    }
}
