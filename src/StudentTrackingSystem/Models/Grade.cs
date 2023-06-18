namespace StudentTrackingSystem.Models;

public class Grade
{
    public int GradeId { get; set; }
    public int StudentId { get; set; }
    public double GradeValue { get; set; }
    public DateTime Date { get; set; }

    public Grade(int gradeId, int studentId, double gradeValue, DateTime date)
    {
        GradeId = gradeId;
        StudentId = studentId;
        GradeValue = gradeValue;
        Date = date;
    }
}