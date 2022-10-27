using System.Collections.Generic;
using System.Xml.Linq;

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

    public string AddStudent(Student student)
    {
      Students.Add(student);

      return WelcomeByTeacher(student) + " " + WelcomeByStudents(student);
    }

    public string WelcomeByTeacher(Student student)
    {
      return $"My name is {Teacher.Name}. I am {Teacher.Age} years old. I am a teacher of class {ClassNumber}. Welcome {student.Name} join class {ClassNumber}.";
    }

    public string WelcomeByStudents(Student newStudent)
    {
      string welcomeMessage = string.Empty;

      foreach (var student in students)
      {
        if (newStudent.Name != student.Name)
        {
          welcomeMessage += $"My name is {student.Name}. I am {student.Age} years old. I am a student of class {ClassNumber}. Welcome {newStudent.Name} join class {ClassNumber}.";
        }
      }

      return welcomeMessage;
    }
  }
}
