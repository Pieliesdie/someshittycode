using System.Collections.Generic;

namespace task2
{
    class Office
    {
        private List<Person> people = new List<Person>();

        public void Add(Person p)
        {
            foreach(Person i in people)
            {
                p.Came += i.Greet;
                i.Gone += p.Goodbye;
            }
            people.Add(p);
            p.OnCame();
        }
        public void Remove(Person p)
        {
            people.Remove(p);
            p.OnGone();
            foreach (Person i in people)
            {
                p.Came -= i.Greet;
                p.Gone -= i.Goodbye;
            }
        }
    }
}
