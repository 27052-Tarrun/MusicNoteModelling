using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicNoteModelling;

public static class MusicalNotes
{
    private static readonly List<Note> Notes =
    [
        new("C", 261.63),
        new("C#", 277.18),
        new("D", 293.66),
        new("D#", 311.13),
        new("E", 329.63),
        new("F", 349.23),
        new("F#", 369.99),
        new("G", 392.00),
        new("G#", 415.30),
        new("A", 440.00),
        new("A#", 466.16),
        new("B", 493.88),
    ];

    public static void DisplayNotes()
    {
        Console.WriteLine("Available Notes: " + string.Join(" ", Notes.Select(n => n.Name)));
    }

    public static Note? GetNote(string name) =>
        Notes.FirstOrDefault(n => n.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}
