using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {      
        static void Main(string[] args)
        {
            List<string> ts = new List<string>();
            ts.Add("a");
            ts.Add("b");
            ts.Add("c");
            ts.Add("f");
            ts.Add("e");
            ts.Add("g");
            EditCollection.OneFromN(ts, 2);
            foreach (string i in ts)
            {
                Console.WriteLine(i);
            }
        }                    
    }         
}