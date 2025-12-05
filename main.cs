using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static string filePath = "notes.txt";

    static void Main(string[] args)
    {
        if (!File.Exists(filePath)) File.Create(filePath).Close();

        if (args.Length == 0)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("  note add \"text\"");
            Console.WriteLine("  note list");
            Console.WriteLine("  note search keyword");
            Console.WriteLine("  note delete index");
            return;
        }


    }
}
