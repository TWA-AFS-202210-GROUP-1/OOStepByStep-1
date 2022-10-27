namespace OOStepByStep;

public class Student : Person
{
    public Student(string name, int age) : base(name, age)
    {
        MyInformation = " I am a student.";
    }
}