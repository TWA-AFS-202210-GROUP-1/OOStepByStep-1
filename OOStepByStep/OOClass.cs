namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        private string teacher;
        private string name;
        private List<string> students;

        public Class(string teacher, string name, List<string> students)
        {
            this.name = name;
            this.teacher = teacher;
            this.students = students;
        }

        public string Print()
        {
           return null;
        }
    }
}
