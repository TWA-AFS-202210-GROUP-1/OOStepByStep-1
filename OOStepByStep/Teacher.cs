namespace OOStepByStep
{
  public class Teacher : Person
  {
    public Teacher(string name, int age, Classroom classroom)
    {
      Name = name;
      Age = age;
      Classroom = classroom;
    }

    public Classroom Classroom { get; set; }

    public override string Introduce()
    {
      return $"My name is {Name}. I am {Age} years old. I am a teacher of class {Classroom.ClassNumber}.";
    }
  }
}
