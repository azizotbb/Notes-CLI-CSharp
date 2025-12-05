using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NotesCliCSharp
{
    public class DeleteNote
    {
        static string filePath = "notes.txt";

        public static void Delete(string indexStr)
        {
            if (string.IsNullOrWhiteSpace(indexStr))
            {
                Console.WriteLine("Please provide a note index to delete.");
                return;
            }

            if (!int.TryParse(indexStr, out int index))
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No notes found.");
                return;
            }

            var notes = File.ReadAllLines(filePath).ToList();

            if (index < 1 || index > notes.Count)
            {
                Console.WriteLine("Index out of range.");
                return;
            }

            string removed = notes[index - 1];
            notes.RemoveAt(index - 1);

            File.WriteAllLines(filePath, notes);
            Console.WriteLine("Deleted note: " + removed);
        }

    }
}
