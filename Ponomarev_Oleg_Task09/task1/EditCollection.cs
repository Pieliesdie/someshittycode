using System.Collections.Generic;

namespace task1
{
    static public class EditCollection
    {
        static public void RemoveEachNItem<T>(ICollection<T> ts, int N, int offset = 0)
        {
            List<T> tmp = new List<T>();
            int _switch = offset;
            foreach (T i in ts)
            {
                if ((_switch % N) == 0)
                {
                    tmp.Add(i);
                }
                _switch++;
            }
            ts.Clear();
            foreach (T i in tmp)
            {
                ts.Add(i);
            }
        }

        public static void OneFromN<T>(ICollection<T> Collection, int step)
        {
            int offset = 0;
            int tmp = 0;
            while (Collection.Count != 1)
            {
                tmp = Collection.Count;
                RemoveEachNItem(Collection, step, offset);
                offset = tmp % step;
            }
        }
    }
}