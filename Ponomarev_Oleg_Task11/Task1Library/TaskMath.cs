using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Library
{
    public static class TaskMath
    {
        public static long Factorial(int n) => n == 0 ? 1 : n * Factorial(n - 1);

        public static int Pow(int n,int x)
        {
            if (x == 0)
                return 1;
            if (x % 2 == 1)
            {
                return Pow(n, x-1) * n;
            }
            else
            {
                n = Pow(n, x / 2);
                return n * n;
            }
        }
    }
}
