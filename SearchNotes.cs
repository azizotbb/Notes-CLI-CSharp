using System;
using System.IO;

public class SearchNotes
{
    static void SearchNotes(string keyword)
    {

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
