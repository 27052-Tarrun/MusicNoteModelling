namespace MusicNoteModelling;

public static class Player
{
    public static void Play(Song song)
    {
        foreach (Note note in song.Notes)
        {
            Console.Beep((int)note.Frequency, note.Duration);
        }
    }
}
