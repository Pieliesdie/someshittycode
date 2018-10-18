namespace Task1
{
    public class Ring : Figure
    {
        public uint Radius { get; set; }

        public Ring(int X, int Y, uint Radius) : base(X, Y)
        {
            this.Radius = Radius;
        }

        public override void Draw(IDraw Drawer)
        {
            Drawer.Draw(this.GetName());
        }

        public override string GetName()
        {
            return "Ring";
        }
    }
}
