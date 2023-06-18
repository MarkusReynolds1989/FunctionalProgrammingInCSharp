namespace StudentTrackingSystemTwo;

/// <summary>
/// Models is a module that holds the plain data records we will use in the program.
/// There is no logic here or constructors, records have a default constructor that will take all the fields and
/// add them for us.
/// </summary>
public static class Models
{
    public record Student(int StudentId,
                          string Firstname,
                          Option<string> MiddleName,
                          string LastName,
                          DateTime DateOfBirth,
                          DateTime EnrollmentDate,
                          Option<DateTime> GraduationDate,
                          Option<DateTime> WithdrawalDate);

    public record Grade(int GradeId, int StudentId, double GradeValue, DateTime Date);

    public record UniversityClass(int UniversityClassId,
                                  int GradeId,
                                  int StudentId,
                                  string UniversityClassName,
                                  Option<DateTime> WithdrawalDate,
                                  Option<DateTime> EnrollmentDate,
                                  Option<DateTime> EndDate);
}