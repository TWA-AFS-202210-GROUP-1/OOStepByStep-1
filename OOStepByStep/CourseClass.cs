using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OOStepByStep.Person;

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

    public ClassWelcome AddStudent(Student student)
    {
        student.CourseClass = this;
        var welcome = new ClassWelcome
        {
            TeacherWelcome = classTeacher?.Welcome(student) ?? string.Empty,
            StudentsWelcome = classStudents.Select(classStudent => classStudent.Welcome(student)).ToList(),
        };
        classStudents.Add(student);
        return welcome;
    }
}