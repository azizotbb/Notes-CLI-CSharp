using System;
using System.IO;

namespace NotesCliCSharp
{
    public class AddNote
    {
        static string filePath = "notes.txt";

        public static void Add(string text)
        {

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Note text is empty!");
                return;
            }

            File.AppendAllText(filePath, text + Environment.NewLine);
            Console.WriteLine("Added note: " + text);
        }
    }
}
