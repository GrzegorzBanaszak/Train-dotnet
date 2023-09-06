public class Student
{
    public string Name { get; set; }
    public List<Subject> Subjects = new List<Subject>();

    public Student(string name, List<Subject> subjects)
    {
        Name = name;
        Subjects = subjects;
    }

    public void displayScores()
    {
        Console.WriteLine($"{Name}\t\tPoints\t\tGrade");
        foreach (var subject in Subjects)
        {
            Console.WriteLine($"Subject\t\t{subject.Points}\t\t{subject.Grade}");
        }
    }
}