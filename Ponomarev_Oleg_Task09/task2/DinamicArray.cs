using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public class DinamicArray<T>:IEnumerable<T>
    {
        private T[] _array;
        public int Capacity => _array.Length;
        public int Length;

        public DinamicArray(IEnumerable<T> Collection)
        {
            IEnumerator<T> Enumerator = Collection.GetEnumerator();
            Enumerator.Reset();
            int count = 0;
            while (Enumerator.MoveNext())
            {
                count++;
            }
            _array = new T[count];
            Length = 0;
            while (Enumerator.MoveNext())
            {
                this.Add(Enumerator.Current);
            }
        }

        public DinamicArray() : this(8) { }

        public DinamicArray(int Count)
        {
            _array = new T[Count];
            Length = 0;         
        }

        public DinamicArray(T[] Array)
        {
            _array = Array;
            Length = Array.Length;
        }

        public void Add(T Value)
        {
            Insert(Value, Length);
        }

        public void AddRange(T[] Array)
        {
            int inputLength = Array.Length;
            if ((inputLength + Length) > Capacity)
            {
                ExpandArray(inputLength + Length);
            }
            for (int i = 0; i < inputLength; i++)
            {
                _array[i + Length] = Array[i];
            }
            Length += inputLength;
        }

        public void ExpandArray(int NewSize)
        {
            T[] newArray = new T[NewSize];
            for (int i = 0; i < Length; i++)
            {
                newArray[i] = _array[i]; 
            }
            _array = newArray;
        }

        public bool Remove(T Value)
        {
            for(int i = 0; i < Length; i++)
            {
                if(EqualityComparer<T>.Default.Equals(Value, _array[i]))
                {
                    for(int j = i; j < Length-1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                    Length--;
                    return true;
                }
            }
            return false;
        }

        public void Insert(T Value,int Index)
        {
            if (Index > Length || Index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (Length >= Capacity)
            {
                ExpandArray(Length * 2);
            }

            for(int i = Length; i > Index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[Index] = Value;
            Length++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
        //public IEnumerator<T> GetEnumerator()
        //{
        //    return ((IEnumerable<T>)_array).GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return ((IEnumerable<T>)_array).GetEnumerator();
        //}

        public T this[int index]
        {
            get
            {
                if (index >= Length||index<0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
        }
        class Enumerator : IEnumerator<T>
        {
            DinamicArray<T> _array;
        
            int index = -1;

            public Enumerator(DinamicArray<T> Array)
            {
                _array = Array;
            }

            public T Current => _array[index];

            object IEnumerator.Current => _array[index];

            public void Dispose()
            {
                _array = null;
            }

            public bool MoveNext()
            {
                if (index >= _array.Length - 1)
                {
                    return false;
                }
                index++;
                return true;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
