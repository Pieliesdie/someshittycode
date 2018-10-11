using System;

namespace task1
{
    public class User
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                _name = value;
            }
        }
        private string _secondname;
        public string Secondname
        {
            get { return _secondname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Second name can't be empty");
                }
                _secondname = value;
            }
        }
        private string _thirdname;
        public string Thirdname
        {
            get { return _thirdname; }
            set => _thirdname = value ?? string.Empty;
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (value > DateTime.Now || value == null)
                {
                    throw new ArgumentException("Wrong birthday");
                }
                _birthday = value;
            }
        }
        public uint Age
        {
            get
            {
                uint age = (uint)(DateTime.Now.Year - Birthday.Year);
                if (DateTime.Now.Month < Birthday.Month ||
                    (DateTime.Now.Month == Birthday.Month && DateTime.Now.Day < Birthday.Day))
                {
                    age--;
                }
                return age;
            }
        }
        public User() : this(new DateTime()){}
        public User(DateTime birthday) : this("unknown", "unknown", "unknown", birthday) { }
        public User(string name, string secondname, string thirdname, DateTime birthday)
        {
            Name = name;
            Secondname = secondname;
            Birthday = birthday;
            Thirdname = thirdname;
        }
        public override string ToString()
        {
            return $"Name - {Name}\nSecondName - {Secondname}\nThirdname - {Thirdname}\n" +
                $"Birthday - {Birthday.ToShortDateString()}\nAge - {Age}";
        }
    }

}
