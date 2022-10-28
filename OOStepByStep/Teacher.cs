namespace OOStepByStep
{
  public class Teacher : Person
  {
    private Classroom classroom;

    public Teacher(string name, int age) : base(name, age)
    {
      Profession = "teacher";
    }

    public void JoinClass(Classroom classroom)
    {
      this.classroom = classroom;
      classroom.AddTeacher(this);
    }

    public override string Introduce()
    {
      return $"My name is {Name}. I am {Age} years old. I am a {Profession} of class {classroom.ClassNumber}.";
    }
  }
}
