using System;

namespace task2
{
    public delegate void PersonCame(Person message, EventCame time);
    public delegate void PersonGone(Person message);

    public class Person
    {
        public string Name { get; }
        public Person(string name)
        {
            Name = name;
        }
        public void Greet(Person anotherPerson, EventCame e)
        {
            switch (e.Time.Hour)
            {
                case (7 - 11):
                    {
                        Console.WriteLine($"'Good Morning, {anotherPerson.Name}!', {Name} said.");
                        break;
                    }
                case (12 - 17):
                    {
                        Console.WriteLine($"'Good day, {anotherPerson.Name}!', {Name} said.");
                        break;
                    }
                case (17 - 24):
                    {
                        Console.WriteLine($"'Good evening, {anotherPerson.Name}!', {Name} said.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"'Hello, {anotherPerson.Name}!', {Name} said.");
                        break;
                    }
            }
        }

        public void Goodbye(Person anotherPerson)
        {
            Console.WriteLine($"'Goodbye, {anotherPerson.Name}!', {Name} said.");
        }

        public event PersonCame Came;
        public event PersonGone Gone;

        public void OnGone()
        {
            Console.WriteLine($"{Name} leaves");
            Gone?.Invoke(this);
        }
        public void OnCame()
        {
            Console.WriteLine($"{Name} comes");
            Came?.Invoke(this,new EventCame(DateTime.Now));
        }

    }
}
