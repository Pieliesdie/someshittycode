using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndexableSeries progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine(progression[5]);
        }
    }
}
