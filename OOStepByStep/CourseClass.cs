using System.Collections;
using System.Collections.Generic;

namespace OOStepByStep;

public class CourseClass
{
    public string ClassName { get; }
    private Teacher classTeacher;
    private IList<Student> classStudents;

    public CourseClass(string className)
    {
        ClassName = className;
        classStudents = new List<Student>();
    }

    public bool AddTeacher(Teacher teacher)
    {
        if (classTeacher != null)
        {
            return false;
        }

        classTeacher = teacher;
        teacher.CourseClass = this;
        return true;
    }

    public bool AddStudent(Student student)
    {
        classStudents.Add(student);
        student.CourseClass = this;
        return true;
    }
}