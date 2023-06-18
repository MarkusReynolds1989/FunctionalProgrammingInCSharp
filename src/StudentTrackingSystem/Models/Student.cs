namespace StudentTrackingSystem.Models;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public DateTime GraduationDate { get; set; }
    public DateTime WithdrawalDate { get; set; }

    public Student(int studentId,
                   string firstName,
                   string middleName,
                   string lastName,
                   DateTime dateOfBirth,
                   DateTime enrollmentDate,
                   DateTime graduationDate,
                   DateTime withdrawalDate)
    {
        StudentId = studentId;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        EnrollmentDate = enrollmentDate;
        GraduationDate = graduationDate;
        WithdrawalDate = withdrawalDate;
    }
}