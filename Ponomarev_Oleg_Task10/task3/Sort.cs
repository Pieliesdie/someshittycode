using System.Threading;

namespace task3
{
    public class Sort
    {
        public event ThreadEnd OnEnd;
        public delegate int StringComparer(string string1, string string2);
        public delegate void ThreadEnd(string message);

        public void NewThreadBubbleSort(string[] A, StringComparer comparer)
        {
            Thread thread = new Thread(() =>
            {
                BubbleSort(A, comparer);
                OnEnd?.Invoke($"sorting thread Ends");
            });
            thread.Start();
        }

        public static void BubbleSort(string[] A, StringComparer comparer)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (comparer(A[j], A[j + 1]) == 1)
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
