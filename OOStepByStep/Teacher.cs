namespace OOStepByStep
{
  public class Teacher : Person
  {
    private Classroom classroom;

    public Teacher(string name, int age) : base(name, age)
    {
    }

    public void JoinClass(Classroom classroom)
    {
      this.classroom = classroom;
    }

    public override string Introduce()
    {
      return $"My name is {Name}. I am {Age} years old. I am a teacher of class {classroom.ClassNumber}.";
    }
  }
}
