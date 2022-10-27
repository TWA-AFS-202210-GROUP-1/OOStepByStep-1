namespace OOStepByStep
{
  public class Student : Person
  {
    private Classroom classroom;

    public Student(string name, int age) : base(name, age)
    {
    }

    public void JoinClass(Classroom classroom)
    {
      this.classroom = classroom;
    }

    public override string Introduce()
    {
      return $"My name is {Name}. I am {Age} years old. I am a student of class {classroom.ClassNumber}.";
    }
  }
}
