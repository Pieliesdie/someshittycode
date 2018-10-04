using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void DrawChristmasTree(int count, bool onCenter, int deltaStars = 1, int center = 0)
        {
            if (count <= 0)
            {
                return;
            }
            int indent = center;
            if (onCenter)
            {
                indent = (count*deltaStars / 2) ;
            }
            string row = "*";
            string space = "";
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < indent; j++)
                {
                    space += " ";
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{space}{row}");
                for (int j = 0; j < deltaStars; j++)
                {
                    row += "*";
                }
                indent--;
                space = "";
            }
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert N");
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                DrawChristmasTree(n, false);
            }
            Console.ReadKey();
        }
    }
}
