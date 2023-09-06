public class Grade
{
    public int[] Scores = new int[2];
    public string GradeType;
    public Grade(int[] scores, string gradeType)
    {
        Scores = scores;
        GradeType = gradeType;
    }

}