using System.Collections.Generic;
using System.Linq;

namespace OOStepByStep
{
  public class Classroom
  {
    private List<Student> students = new List<Student>();

    public Classroom(int classNumber)
    {
      ClassNumber = classNumber;
    }

    public Teacher Teacher { get; set; }
    public int ClassNumber { get; set; }
    public List<Student> Students { get => students; set => students = value; }

    public void AddTeacher(Teacher teacher)
    {
      Teacher = teacher;
    }

    public void AddStudent(Student student)
    {
      Students.Add(student);
    }

    public string ShowWelcome(Student newStudent)
    {
      return $"{WelcomeByTeacher(newStudent)} {WelcomeByStudents(newStudent)}".Trim();
    }

    private string WelcomeByTeacher(Student newStudent)
    {
      return Teacher == null ? string.Empty : ConstructWelcomeMessage(Teacher, newStudent);
    }

    private string WelcomeByStudents(Student newStudent)
    {
      if (students.Count != 0)
      {
        var welcomeMessageList = students.Where(student => newStudent.Name != student.Name).Select(student => ConstructWelcomeMessage(student, newStudent)).ToList();

        return string.Join(" ", welcomeMessageList);
      }
      else
      {
        return string.Empty;
      }
    }

    private string ConstructWelcomeMessage(Person person, Person welcomedPerson)
    {
      return $"My name is {person.Name}. I am {person.Age} years old. I am a {person.Profession} of class {ClassNumber}. Welcome {welcomedPerson.Name} join class {ClassNumber}.";
    }
  }
}
