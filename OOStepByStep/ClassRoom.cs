using System.Collections.Generic;

namespace OOStepByStep
{
  public class ClassRoom
  {
    private List<Student> students = new List<Student>();

    public ClassRoom(int classNumber)
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
  }
}
