namespace MusicNoteModelling;

public static class NoteParser
{
    public static Song ParseSong(string input)
    {
        Song song = new();
        string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            Note? note = MusicalNotes.GetNote(token);
            if (note != null)
                song.Notes.Add(note);
            else
                Console.WriteLine($"[Warning] Invalid note ignored: {token}");
        }
        return song;
    }
}
