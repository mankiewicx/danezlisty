using System;
namespace List.ConsoleApp
{
    class List
    {
        public static void Main(string[] args)
        {
            string list = System.IO.File.ReadAllText("./../../../NameList.txt");
            string[] arrtext = list.Split("\n");

            Console.WriteLine("Imię i Nazwisko 246 osoby z listy to: " + arrtext[246] + "\n");
            foreach (var name in arrtext)
            {
                if (name.Contains("Anna"))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}

