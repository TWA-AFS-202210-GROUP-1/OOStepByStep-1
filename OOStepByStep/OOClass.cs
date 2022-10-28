namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;

    public class OOClass
    {
        private Teacher teacher;
        private int name;
        private List<Student> students = new List<Student>();

        public OOClass(int name)
        {
            this.name = name;
        }

        public OOClass()
        {
        }

        public void AddOrChangeTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            this.teacher.Classname = this.name;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.Classname = this.name;
        }

        public string Print()
        {
           return null;
        }
    }
}
