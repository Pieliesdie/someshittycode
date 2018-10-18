namespace Task4
{
    public abstract class Landscape : GameItem
    {
        public bool IsFrontier;
        public Landscape(string Name,int X,int Y,bool IsAvailable,bool IsFrontier) : base(Name, X, Y, IsAvailable)
        {
            this.IsFrontier = IsFrontier;
        }
    }
}
