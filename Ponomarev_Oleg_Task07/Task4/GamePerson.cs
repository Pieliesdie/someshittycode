namespace Task4
{
    public abstract class GamePerson : GameObject
    {
        public GamePerson(string Name,int X,int Y,double HP,bool IsEnemy) : base(Name,X,Y)
        {
            this.HP = HP;
            this.IsEnemy = IsEnemy;
        }
        abstract public void Attack();
        abstract public void Move();
        abstract public double HP { get; set; }
        abstract public bool IsEnemy { get;set; }
    }
}
