using System;
using System.IO;

public class DeleteNote
{
    static void DeleteNote(string indexStr)
    {
        if (!int.TryParse(indexStr, out int index))
        {
            Console.WriteLine("Invalid index.");
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
