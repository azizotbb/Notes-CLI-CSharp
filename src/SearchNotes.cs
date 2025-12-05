using System;
using System.IO;
using System.Linq;

namespace NotesCliCSharp
{
    public class SearchNotes
    {
        static string filePath = "data/notes.txt";

        public static void Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("Please provide a keyword to search for.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No notes found.");
                return;
            }

            // Read all notes from the file
            var notes = File.ReadAllLines(filePath);
            var results = notes
                .Select((note, index) => new { note, index })
                .Where(x => x.note.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
            // Check if any matches found
            if (!results.Any())
            {
                Console.WriteLine("No matching notes.");
                return;
            }
            // Display matching notes
            foreach (var item in results)
            {
                Console.WriteLine($"{item.index + 1}. {item.note}");
            }
        }

    }
}
