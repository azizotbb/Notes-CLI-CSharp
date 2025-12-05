using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static string filePath = "notes.txt";

    static void Main(string[] args)
    {
        // Ensure the notes file exists
        if (!File.Exists(filePath)) File.Create(filePath).Close();
        // Handle commands
        if (args.Length == 0)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("  note add \"text\"");
            Console.WriteLine("  note list");
            Console.WriteLine("  note search keyword");
            Console.WriteLine("  note delete index");
            return;
        }


        string command = args[0].ToLower();
        switch (command)
        {
            // Add a new note
            case "add":
                AddNote.AddNote(string.Join(" ", args.Skip(1)));
                break;
            // List all notes
            case "list":
                ListNotes.ListNotes();
                break;
            // Search notes by keyword
            case "search":
                SearchNotes.SearchNotes(string.Join(" ", args.Skip(1)));
                break;
            // Delete a note by index
            case "delete":
                DeleteNote.DeleteNote(args.Skip(1).FirstOrDefault());
                break;
            // Unknown command
            default:
                Console.WriteLine("Unknown command");
                break;
        }



    }
}
