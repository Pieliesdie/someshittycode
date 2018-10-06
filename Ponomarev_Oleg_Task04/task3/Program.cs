using System;
using System.Globalization;
using System.Linq;

namespace task3
{
    class Program
    {
        static string[,] DiffInCult(CultureInfo culture1, CultureInfo culture2)
        {
            int rows = 3, column = 3;
            string[,] result = new string[rows, column];
            double number = 100100.1001001;
            DateTime time = DateTime.Now;
            result[0, 0] = "";
            result[1, 0] = "time";
            result[2, 0] = "number";
            result[0, 1] = culture1.DisplayName;
            result[0, 2] = culture2.DisplayName;
            result[1, 1] = time.ToString(culture1);
            result[1, 2] = time.ToString(culture2);
            result[2, 1] = number.ToString(culture1);
            result[2, 2] = number.ToString(culture2);
            return result;
        }

        static int LongestRow(string [,] array)
        {
            int max = 0;
            foreach (string i in array)
            {
                if (i.Count() > max)
                {
                    max = i.Count();
                }
            }
            return max;

        }

        static void ShowArray(string[,] diff)
        {            
            string result = "";
            int rows = diff.GetUpperBound(0) + 1,
                columns = diff.GetUpperBound(1) + 1,
                max = LongestRow(diff);     
            int length = max * rows + columns * 2;
            result += $"{new string('-', length)}\n";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += $"|{diff[i, j]}{new string(' ', max - diff[i, j].Count())}|";
                }
                result += $"\n{new string('-', length)}\n";
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            ShowArray(DiffInCult(CultureInfo.CreateSpecificCulture("en-US"), 
                CultureInfo.CreateSpecificCulture("ru-RU")));
            ShowArray(DiffInCult(CultureInfo.CreateSpecificCulture("en-US"),
                CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
