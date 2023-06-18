using System.Data.SqlTypes;
using System.Globalization;

namespace StudentTrackingSystemTwo;

public static class Controllers
{
    public static class GradeController
    {
        public static async Task<bool> InsertGrade(Models.Grade grade)
        {
            try
            {
                await using var connection = new SqliteConnection("");
                await connection.OpenAsync();

                var result = await connection.ExecuteAsync(
                    @"insert into grade(StudentId, Gradevalue, Date) values (@StudentId, @GradeValue, @Date)",
                    new
                    {
                        grade.StudentId,
                        grade.GradeValue,
                        Date = new DbString()
                        {
                            Value = grade.Date.ToString(CultureInfo.CurrentCulture),
                            IsFixedLength = true,
                            Length = 45,
                            IsAnsi = false,
                        }
                    });
            }
            catch (SqliteException exception)
            {
                Debug.WriteLine(exception);
            }

            return true;
        }
    }

    public static class StudentController
    {
    }

    public static class UniversityClassController
    {
    }
}