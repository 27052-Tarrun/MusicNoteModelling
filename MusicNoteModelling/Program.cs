namespace MusicNoteModelling;

public static class Program
{
    public static void Main()
    {
        MusicalNotes.DisplayNotes();

        Console.Write("\nEnter notes separated by spaces (e.g., C E G C):");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input)) return;
        Song song = NoteParser.ParseSong(input);

        if (song.Notes.Count > 0)
        {
            Console.WriteLine("Playing song...");
            Player.Play(song);
        }

        Console.ReadKey();
    }
}