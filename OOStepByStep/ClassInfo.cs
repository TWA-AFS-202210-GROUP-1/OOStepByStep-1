using System;
using System.Collections.Generic;

namespace OOStepByStep
{
    public class ClassInfo
    {
        private List<Student> students;
        private Teacher teacher;
        public ClassInfo(List<Student> students, Teacher teacher)
        {
            this.students = students;
            this.teacher = teacher;
        }

        public string AddStudent(Student newComer)
        {
            List<string> welcomeInfo = new List<string>();
            welcomeInfo.Add(teacher.Introduce(newComer.Name));
            foreach (Student student in students)
            {
                welcomeInfo.Add(student.Introduce(newComer.Name));
            }

            var result = string.Join(" ", welcomeInfo.ToArray());

            students.Add(newComer);
            return result;
        }
    }
}