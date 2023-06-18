namespace StudentTrackingSystemTwo;

public static class Models
{
    public record Student(int StudentId,
                          string Firstname,
                          string MiddleName,
                          string LastName,
                          DateTime DateOfBirth,
                          DateTime EnrollmentDate,
                          DateTime GraduationDate,
                          DateTime WithdrawalDate);

    public record Grade(int GradeId, int StudentId, double GradeValue, DateTime Date);

    public record UniversityClass(int UniversityClassId,
                                  int GradeId,
                                  int StudentId,
                                  string UniversityClassName,
                                  DateTime WithdrawalDate,
                                  DateTime EnrollmentDate,
                                  DateTime EndDate);
}