namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using Xunit;

    public class TeacherTest
    {
        [Fact]
        public void Should_return_teacher_information_when_introduce_given_name_and_age()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30);
            //when
            string info = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", info);
        }

        [Fact]
        public void Should_return_teacher_information_when_introduce_given_name_and_age_class()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30, 2);
            //when
            string info = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", info);
        }
    }
}
