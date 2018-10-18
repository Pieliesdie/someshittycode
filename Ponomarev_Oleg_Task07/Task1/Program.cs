using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void ShowFigures(List<Figure> Figures,IDraw Drawer)
        {
            foreach (Figure i in Figures)
            {
                i.Draw(Drawer);
                Console.WriteLine($"X = {i.X}\nY = {i.Y}");
                if (i is Ring)
                {
                    Console.WriteLine("Ring's radius " + ((Ring)i).Radius);
                }
                if (i is Rectangle)
                {
                    Console.WriteLine($"Reactangle's weight/height " +
                        $"{((Rectangle)i).Height}/{((Rectangle)i).Weight}");
                }
            }
        }

        static void Main(string[] args)
        {
            List<Figure> Figures = new List<Figure>();
            Figures.Add(new Ring(3, 4, 5));
            Figures.Add(new Rectangle(3, 4, 5, 6));
            ShowFigures(Figures, new ConsoleDraw());       
        }
    }
}
