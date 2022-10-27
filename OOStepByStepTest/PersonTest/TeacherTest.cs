using OOStepByStep.Person;

namespace OOStepByStepTest.PersonTest
{
    using OOStepByStep;
    using Xunit;

    public class TeacherTest
    {
        [Fact]
        public void Should_introduce_teacher_with_name_and_age_when_introduce_give_teacher_with_name_age()
        {
            // given
            var teacher = new Teacher("Amy", 30);

            // when
            var result = teacher.Introduce();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }

        [Fact]
        public void Should_teacher_introduce_with_class_2_when_add_teacher_to_class_given_class_name_class_2()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            var courseClass = new CourseClass("class 2");
            courseClass.AddTeacher(teacher);
            //when

            var result = teacher.Introduce();

            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }
    }
}