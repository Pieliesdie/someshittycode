namespace task2
{
    class Program
    {     
        static void Main(string[] args)
        {
            Office build = new Office();
            Person john = new Person("John");
            Person mary = new Person("Mary");
            Person hugo = new Person("Hugo");
            build.Add(john);
            build.Add(mary);
            build.Add(hugo);
            build.Remove(john);
        }
    }
}
