namespace Common
{
    using System;
    using System.Collections.Generic;

    public partial class Users
    {

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public uint Age { get
            {
                uint age = (uint)(DateTime.Now.Year - Birthday.Year);
                if (DateTime.Now.Month < Birthday.Month ||
                    (DateTime.Now.Month == Birthday.Month && DateTime.Now.Day < Birthday.Day))
                {
                    age--;
                }
                return age;
            } }

    }
}
