namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using Xunit;

    public class ClassInfoTest
    {
        [Fact]
        public void Should_return_welcome_introduce_of_all_class_member_when_new_student_come_to_class_given_name_and_age_class()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30, 2);
            List<Student> students = new List<Student>();
            Student student = new Student("Tom", 18, 2);
            ClassInfo classInfo = new ClassInfo(students, teacher);
            //when
            string msg = classInfo.AddStudent(student);
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2", msg);
        }
    }
}
