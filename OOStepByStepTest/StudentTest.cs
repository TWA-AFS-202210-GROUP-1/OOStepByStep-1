using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTest
    {
        [Fact]
        public void Should_introduce_student_with_name_and_age_when_introduce_give_student_with_name_age()
        {
            // given
            var student = new Student("Tom", 18);

            // when
            var result = student.Introduce();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", result);
        }

        [Fact]
        public void Should_student_introduce_with_class_2_when_add_student_to_class_given_class_name_class_2()
        {
            //given
            var student = new Student("Tom", 18);
            var courseClass = new CourseClass("class 2");
            courseClass.AddStudent(student);
            //when

            var result = student.Introduce();

            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", result);
        }
    }
}