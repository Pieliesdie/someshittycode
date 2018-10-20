using System.Collections.Generic;

namespace task3
{
    class WordComparer : IEqualityComparer<Word>
    {
        public bool Equals(Word x, Word y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Word obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
