namespace TransitionParadigm;

// Change an OOP project to be functional.
public class Student
{
    private string Name { get; set; }
    private int Age { get; set; }
    private double Gpa { get; set; }

    public Student(string name, int age, double gpa)
    {
        Name = name;
        Age = age;
        Gpa = gpa;
    }
}