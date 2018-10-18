namespace Task1
{
    public class Rectangle : Figure
    {
        public uint Weight;
        public uint Height;
        public Rectangle(int X, int Y, uint Weight, uint Height) : base(X, Y)
        {
            this.Weight = Weight;
            this.Height = Height;
        }
        public override void Draw(IDraw Drawer)
        {
            Drawer.Draw(this.GetName());
        }
        public override string GetName()
        {
            return "Reactangle";
        }
    }
}
