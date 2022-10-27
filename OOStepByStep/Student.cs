namespace OOStepByStep
{
  public class Student : Person
  {
    private Classroom classroom;

    public Student(string name, int age) : base(name, age)
    {
      Profession = "student";
    }

    public void JoinClass(Classroom classroom)
    {
      this.classroom = classroom;
      classroom.AddStudent(this);
      classroom.ShowWelcome(this);
    }

    public override string Introduce()
    {
      return $"My name is {Name}. I am {Age} years old. I am a {Profession} of class {classroom.ClassNumber}.";
    }
  }
}
