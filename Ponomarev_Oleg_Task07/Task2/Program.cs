using DemoApplication;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries progression = new GeometricalProgression(2, 2);
            Console.WriteLine("Progression:");
            InterfacesDemo.PrintSeries(progression);
        }
    }
}
