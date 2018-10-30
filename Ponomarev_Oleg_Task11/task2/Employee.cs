using System;
using task1;

namespace Task1
{
    public class Employee : User,IEquatable<Employee>
    {    
        private string position;
        public string Position
        {
            get => position;
            set => position = value ?? throw new ArgumentException("value can't be null");
        }
        private uint experience;
        public uint Experience
        {
            get => experience;
            set => experience = value;
        }
        public Employee() : base()
        {
            Position = "unknown";
            Experience = 0;
        }
        public Employee(string name, string secondname, string thirdname,
            DateTime birthday,uint experience,string position) : base(name, secondname, thirdname, birthday)
        {
            Position = position;
            Experience = experience;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPosition - {Position}\nExperience - {Experience}";
        }

        public bool Equals(Employee other)
        {
            return (this.ToString() == other.ToString());
        }
    }
}
