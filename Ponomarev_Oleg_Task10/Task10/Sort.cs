namespace Task10
{
    static class Sort
    {
        public delegate int StringComparer(string string1, string string2);

        public static void BubbleSort(string[] A, StringComparer comparer)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (comparer(A[j], A[j + 1])== 1)
                    {
                        string temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
        }
    }
}
