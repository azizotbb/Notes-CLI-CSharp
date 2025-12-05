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

    }
}
