using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee i = new Employee("1", "2", "3", new DateTime(4,6,3), 6, "7");
            Employee j = new Employee("1", "6", "3", new DateTime(9), 6, "7");
            Employee k = new Employee("1", "2", "3", new DateTime(4, 6, 3), 6, "7");
            Console.WriteLine(i.Equals(j) + " " + i.Equals(k));
        }
    }
}
