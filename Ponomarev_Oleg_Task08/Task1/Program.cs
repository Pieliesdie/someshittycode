using System;

namespace Task1
{
    //class A : IEquatable<T>
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            DinamicArray<int> array = new DinamicArray<int>(2);
            array.Add(5);
            array.Add(5);
            int[] array3 = new int[2] { 1, 3 };
            array.Insert(3, 2);
            array.AddRange(array3);
            array.Add(5);
            array.Remove(3);
            array.Add(9);
            array.Insert(4, 1);
            array.Insert(4, 1);
            array.Insert(4, 1);
            int[] array2 = array.test();
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
