using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{    
    class keyword
    {
        public string name;
        public int count;
        public keyword(string Name,int Count)
        {
            name = Name;
            count = Count;
        }
    }

    class Program
    {
        string keywordsCsharp = "abstract as base bool break byte case catch char checked class const continue " +
            "decimal default delegate do double else enum event explicit extern false finally " +
            "fixed float for foreach goto if implicit in int interface internal is lock long " +
            "namespace new null object operator out override params private protected public " +
            "readonly ref return sbyte sealed short sizeof stackalloc static string struct " +
            "switch this throw true try typeof uint ulong unchecked unsafe ushort " +
            "using static virtual void volatile while";

        public List<keyword> StrToMassive(string s)
        {
            string [] words = s.Split(' '); //!
            List<keyword> returnList = new List<keyword>();
            foreach (string i in words)
            {
                returnList.Add(new keyword(i,0));
            }
            return returnList;
        }

        public string ReadFileWithoutComments(string _path)
        {
            string file="error";
            try
            {
                using (StreamReader sr = new StreamReader(_path))
                {
                    file = sr.ReadToEnd();
                }
                file = Regex.Replace(file, "(.*\".*)(//)(.*\".*)", "$1$3", RegexOptions.Multiline); 
                file = Regex.Replace(file, @"\w*//.*$", "", RegexOptions.Multiline); 
                file = Regex.Replace(file, "(.*\".*)(/[*])(.*\".*)", "$1$3");
                file = Regex.Replace(file, "(.*\".*)([*]/)(.*\".*)", "$1$3");
                file = Regex.Replace(file, @"/\*(.*?)\*/", "", RegexOptions.Singleline);
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка чтения файла");
            }
            return file;
        }

        public void CountWords(List<keyword> keywords,string file)
        {
            foreach (keyword i in keywords)
            {
                i.count = new Regex($@"\b({i.name})\b").Matches(file).Count;
            }
        }

        public void LookAtSortedWords (List<keyword> keywords)
        {
            List<keyword> _keywords = new List<keyword>(keywords);
            _keywords = _keywords.OrderBy(x => x.name).ToList();
            foreach (keyword i in _keywords)
            {
                Console.WriteLine($"{i.name} - {i.count}");
            }
        }

        public void LookAtTOP5 (List<keyword> keywords)
        {
            List<keyword> _keywords = new List<keyword>(keywords);
            _keywords = keywords.OrderByDescending(x => x.count).ToList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{_keywords[i].name} - {_keywords[i].count}");
            }
        }

        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Введите путь к файлу или нажмите Enter для пути по умолчанию(../../Program.cs) ");
            path = Console.ReadLine();
            if (path == "")
            {
                path = "../../Program.cs";
            }
            Program method = new Program();
            List<keyword> keywords = method.StrToMassive(method.keywordsCsharp);
            string file = method.ReadFileWithoutComments(path);
            if (file != "error")
            {
                Console.WriteLine("Name - Count");
                method.CountWords(keywords, file);
                method.LookAtSortedWords(keywords);
                Console.WriteLine("\n TOP 5 СЛОВ \n");
                method.LookAtTOP5(keywords);
            }
            Console.ReadKey();
        }
    }
}
