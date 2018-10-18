namespace Task4
{
    public abstract class GameItem : GameObject
    {
        abstract public bool IsAvailable { get; set; }
        abstract public void GetItem();
        public GameItem(string Name, int X, int Y, bool IsAvailable) : base(Name, X, Y)
        {
            this.IsAvailable = IsAvailable;
        }
    }
}
