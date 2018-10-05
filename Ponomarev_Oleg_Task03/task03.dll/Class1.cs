using System;

namespace Massives
{
    public class Massive
    {
        public static void BubbleSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
        }

        public static int[] GetRandomMassive(int x, int min, int max)
        {
            Random rand = new Random();
            int[] randmass1 = new int[x];
            for (int i = 0; i < x; i++)
            {
                randmass1[i] = rand.Next(min, max);
            }
            return randmass1;
        }

        public static int[,] GetRandomMassive(int x, int y, int min, int max)
        {
            Random rand = new Random();
            int[,] randmass2 = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    randmass2[i, j] = rand.Next(min, max);
                }
            }
            return randmass2;
        }

        public static int[,,] GetRandomMassive(int x, int y, int z, int min, int max)
        {
            Random rand = new Random();
            int[,,] randmass3 = new int[x, y, z];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        randmass3[i, j, k] = rand.Next(min, max);
                    }
                }
            }
            return randmass3;
        }

        public static void SeeMassive(Array mass)
        {
            foreach (int i in mass)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

