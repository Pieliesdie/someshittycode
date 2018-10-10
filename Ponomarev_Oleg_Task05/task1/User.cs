using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class User
    {
        private string _name;
        public string Name
        {
            get { return _name; }
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
            set
            {
                if (value != null)
                {
                    _thirdname = value;
                }
                else
                {
                    _thirdname = string.Empty;
                }
            }
        }
        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (value <= DateTime.Now && value != null)
                {
                    _birthday = value;
                }
                else
                {
                    throw new ArgumentException("Wrong birthday");
                }
            }
        }
        public uint Age { get { return (uint)DateTime.Now.Year - (uint)Birthday.Year; } }
        public User() : this(new DateTime()) { }
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
