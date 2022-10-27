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
            students.Add(newComer);
            return teacher.Introduce(newComer.Name);
        }
    }
}
