using System;
using System.IO;

public class ListNotes
{
    static void ListNotes()
    {
        // Read all notes from the file
        var notes = File.ReadAllLines(filePath);
        // Check if there are any notes
        if (notes.Length == 0)
        {
            Console.WriteLine("No notes yet.");
            return;
        }
        // Display each note with its index
        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {notes[i]}");
        }
    }

}
