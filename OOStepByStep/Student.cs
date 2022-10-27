namespace OOStepByStep
{
  public class Student : Person
  {
    public Student(string name, int age, ClassRoom classroom)
    {
      Name = name;
      Age = age;
      Classroom = classroom;
    }

    public ClassRoom Classroom { get; set; }

    public override string Introduce()
    {
      return $"My name is {Name}. I am {Age} years old. I am a student of class {Classroom.ClassNumber}.";
    }
  }
}
