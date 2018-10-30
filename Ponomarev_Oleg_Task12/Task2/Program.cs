using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = null;
            while (true)
            {
                Console.WriteLine("Do you want watch or restore?");
                switch (Console.ReadLine())
                {
                    case "watch":
                        Console.WriteLine("Insert path");
                        string path = Console.ReadLine();
                        logger = new Logger(path, "E:\\logs", "*.txt", true);
                        Console.WriteLine("Press any button to exit...");
                        Console.Read();
                        break;
                    case "restore":
                        if (!(logger == null))
                        {
                            Console.WriteLine("Insert Date dd-mm-yyyy@hh.mm.ss");
                            Console.WriteLine(logger.RestoreBackup(Console.ReadLine()));
                        }
                        break;
                }
            }
        }
    }
}
