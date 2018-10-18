using System;
using System.Collections.Generic;

namespace Task1
{
    public class DinamicArray<T> where T : IEquatable<T>
    {
        private T[] _array;
        public int Capacity => _array.Length;
        public int Length;

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
    }
}
