namespace Task4
{
    public abstract class GameObject
    {
        public string Name;
        public int X, Y;
        public GameObject(string Name,int X,int Y)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                this.Name = Name;
            }
            this.X = X;
            this.Y = Y;
        }
    }
}
