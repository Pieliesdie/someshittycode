using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString i = new MyString("qwerty");
            MyString bi = new MyString("qwerty");
            MyString c = i - 3;
            c = c + bi;
            Console.WriteLine(c==c);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
