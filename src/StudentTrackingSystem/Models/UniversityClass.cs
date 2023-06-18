namespace StudentTrackingSystem.Models;

public class UniversityClass
{
    public DateTime EndDate { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public DateTime WithdrawalDate { get; set; }
    public int GradeId { get; set; }
    public int StudentId { get; set; }
    public int UniversityClassId { get; set; }
    public string UniversityClassName { get; set; }

    public UniversityClass(int gradeId,
                           int studentId,
                           int universityClassId,
                           string universityClassName,
                           DateTime enrollmentDate,
                           DateTime withdrawalDate,
                           DateTime endDate)
    {
        EndDate = endDate;
        EnrollmentDate = enrollmentDate;
        GradeId = gradeId;
        StudentId = studentId;
        UniversityClassId = universityClassId;
        UniversityClassName = universityClassName;
        WithdrawalDate = withdrawalDate;
    }
}