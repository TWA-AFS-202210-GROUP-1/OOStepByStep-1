using System.Collections.Generic;
using OOStepByStep;
using OOStepByStep.Person;
using Xunit;

namespace OOStepByStepTest
{
    public class CourseClassTest
    {
        [Fact]
        public void Should_return_true_when_add_teacher_given_teacher_to_class()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            var courseClass = new CourseClass("Class 2");
            //when

            var result = courseClass.AddTeacher(teacher);

            //then
            Assert.True(result);
        }

        [Fact]
        public void Should_return_false_when_add_teacher_given_class_has_teacher()
        {
            //given
            var amy = new Teacher("Amy", 30);
            var jane = new Teacher("Jane", 40);
            var courseClass = new CourseClass("Class 2");
            //when
            courseClass.AddTeacher(amy);
            var result = courseClass.AddTeacher(jane);

            //then
            Assert.False(result);
        }

        [Fact]
        public void Should_not_get_teacher_welcome_when_add_student_given_class_has_no_teacher()
        {
            //given
            var student = new Student("Tom", 18);
            var courseClass = new CourseClass("Class 2");
            //when

            var result = courseClass.AddStudent(student);

            //then
            Assert.Equal(string.Empty, result.TeacherWelcome);
            Assert.Equal(0, result.StudentsWelcome.Count);
        }

        [Fact]
        public void Should_get_teacher_welcome_when_add_student_given_class_has_teacher()
        {
            //given
            var student = new Student("Tom", 18);
            var teacher = new Teacher("Amy", 30);
            var courseClass = new CourseClass("class 2");
            //when
            courseClass.AddTeacher(teacher);
            var result = courseClass.AddStudent(student);

            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.", result.TeacherWelcome);
        }

        [Fact]
        public void Should_get_student_welcome_when_add_student_given_class_has_students()
        {
            //given
            var tom = new Student("Tom", 18);
            var bob = new Student("Bob", 20);
            var me = new Student("Xu", 25);
            var courseClass = new CourseClass("class 2");
            //when
            courseClass.AddStudent(tom);
            courseClass.AddStudent(bob);

            var result = courseClass.AddStudent(me);

            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2. Welcome Xu join class 2.", result.StudentsWelcome[0]);
            Assert.Equal("My name is Bob. I am 20 years old. I am a student of class 2. Welcome Xu join class 2.", result.StudentsWelcome[1]);
        }

        [Fact]
        public void Should_not_get_student_welcome_when_add_student_given_class_has_no_student()
        {
            //given
            var me = new Student("Xu", 25);
            var courseClass = new CourseClass("class 2");
            //when

            var result = courseClass.AddStudent(me);

            //then
            Assert.Equal(0, result.StudentsWelcome.Count);
        }
    }
}
