public class Subject
{
    public int Points { get; set; }
    public string Grade { get; set; } = "";

    public Subject(int points)
    {
        Points = points;
    }
}