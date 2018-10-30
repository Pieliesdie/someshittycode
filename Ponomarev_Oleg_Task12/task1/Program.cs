using System.IO;
using System.Text.RegularExpressions;

namespace task1
{
    class Program
    {
        static void SqrNumbers(string path)
        {
            string file;
            using (StreamReader rider = new StreamReader(path))
            {
                file = rider.ReadToEnd();
            }
            file=Regex.Replace(file, @"\d+",x=>(int.Parse(x.Value)* int.Parse(x.Value)).ToString());
            using (StreamWriter writer = new StreamWriter(path,false))
            {
                writer.Write(file);
            }
        }

        static void Main(string[] args)
        {
            SqrNumbers("e:\\1.txt");
        }
    }
}
