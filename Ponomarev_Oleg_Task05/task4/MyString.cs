using System;
using System.Text;

namespace task4
{
    public class MyString
    {
        private readonly char[] mystring;
        public static MyString operator +(MyString one, MyString two)
        {
            char[] result = new char[one.mystring.Length + two.mystring.Length];
            for (int i = 0; i < one.mystring.Length; i++)
            {
                result[i] = one.mystring[i];
            }
            for (int i = 0; i < two.mystring.Length; i++)
            {
                result[i + one.mystring.Length] = two.mystring[i];
            }
            return new MyString(result);
        }
        public static MyString operator -(MyString one, uint two)
        {
            if (!(one.mystring.Length - two > 0))
                throw new Exception("String smaller than number");
            char[] result = new char[one.mystring.Length - two];
            for (int i = 0; i < one.mystring.Length - two; i++)
            {
                result[i] = one.mystring[i];
            }
            return new MyString(result);
        }
        public static bool operator ==(MyString one, MyString two)
        {
            if (one.mystring.Length != two.mystring.Length)
            {
                return false;
            }
            for (int i = 0; i < one.mystring.Length; i++)
            {
                if (one.mystring[i] != two.mystring[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(MyString one, MyString two)
        {
            return !(one == two);
        }
        private MyString(char[] i)
        {
            mystring = i;
        }
        public MyString(string input)
        {
            mystring = input.ToCharArray();
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (char i in this.mystring)
            {
                result.Append(i);
            }
            return result.ToString();
        }
    }

}
