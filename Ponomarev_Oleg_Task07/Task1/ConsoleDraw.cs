using System;

namespace Task1
{
    public class ConsoleDraw : IDraw
    {
        public void Draw(string f)
        {
            Console.WriteLine($"This is {f}");
        }
    }
}
