public class Teacher
{
    private List<Grade> grades = new List<Grade>(){
                new Grade(new int[] { 97, 100 }, "A+"),
                new Grade(new int[] { 93, 96 }, "A"),
                new Grade(new int[] { 90 , 92}, "A-"),
                new Grade(new int[] { 87 , 89}, "B+"),
                new Grade(new int[] { 83 , 86}, "B"),
                new Grade(new int[] { 80 , 82}, "B-"),
                new Grade(new int[] { 77 , 79}, "C+"),
                new Grade(new int[] { 73 , 76 }, "C"),
                new Grade(new int[] { 70, 76 }, "C-"),
                new Grade(new int[] { 67, 69 }, "D+"),
                new Grade(new int[] { 63, 66 }, "D"),
                new Grade(new int[] { 60, 62 }, "D-"),
                new Grade(new int[] { 0, 59 }, "F"),
                };
    public Teacher()
    {

    }

    public void rateStrudent(Student student)
    {
        student.Subjects.ForEach(subject =>
        {
            subject.Grade = grades.FirstOrDefault(grade => grade.Scores[0] <= subject.Points && grade.Scores[1] >= subject.Points)?.GradeType ?? throw new ArgumentException("");

        });



    }
}