using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int StringComparer(string string1, string string2)//1 больше 2
        {
            if (string1.Length > string2.Length)
                return 1;
            if (string1.Length < string2.Length)
                return 0;
            return StrToDouble(string1) > StrToDouble(string2) ? 1 : 0;

            double StrToDouble(string _string)
            {
                double tmp = 0;
                foreach (char i in _string.ToLower())
                {
                    tmp += Char.GetNumericValue(i);
                }
                return tmp;
            }
        }

        static void Main(string[] args)
        {
            string[] test = new string[] { "aaa", "bbb", "aaaaa", "CCCCccc", "qqqqqqqqq", "фвафвав" };
            string[] test1 = new string[] { "aaa", "bbb", "aaaaa", "CCCCccc", "qqqqqqqqq", "фвафвав" };
            Sort sort = new Sort();
            sort.OnEnd += ShowMessage;
            sort.NewThreadBubbleSort(test,StringComparer);
            sort.NewThreadBubbleSort(test1,StringComparer);
            foreach (string i in test)
            {
                Console.WriteLine(i);
            }
        }
    }
}
