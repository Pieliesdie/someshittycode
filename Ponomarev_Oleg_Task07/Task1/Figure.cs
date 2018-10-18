namespace Task1
{
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public abstract string GetName();
        public abstract void Draw(IDraw Drawer);
    }
}
