using System;

namespace task1
{
    class User
    {
        private string _name;
        public string Name { get { return _name; }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
            }
        }
        private string _secondname;
        public string Secondname
        {
            get { return _secondname; }
            set
            {
                if (value != null)
                {
                    _secondname = value;
                }
            }
        }
        private string _thirdname;
        public string Thirdname
        {
            get { return _thirdname; }
            set
            {
                if (value != null)
                {
                    _thirdname = value;
                }
            }
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (value <= DateTime.Now && value!=null)
                {
                    _birthday = value;
                }
            }
        }
        public uint Age { get { return (uint)DateTime.Now.Year - (uint)Birthday.Year; }}
        public User() : this(new DateTime()) { }
        public User(DateTime birthday) : this("unknown", "unknown", "unknown",birthday) { }
        public User(string name,string secondname,string thirdname,DateTime birthday)
        {
            Name = name;
            Secondname = secondname;
            Birthday = birthday;
            Thirdname = thirdname;
        }
        public string GetInfo()
        {
            return $"Name - {Name}\nSecondName - {Secondname}\nThirdname - {Thirdname}\n" +
                $"Birthday - {Birthday.ToShortDateString()}\nAge - {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User();
            Console.WriteLine(person.GetInfo());
            Console.ReadKey();
        }
    }
}
