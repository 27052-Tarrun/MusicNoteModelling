namespace MusicNoteModelling;

public class Note(string name, double frequency, int duration = 500)
{
    public string Name { get; } = name;
    public double Frequency { get; } = frequency;
    public int Duration { get; } = duration;
}
