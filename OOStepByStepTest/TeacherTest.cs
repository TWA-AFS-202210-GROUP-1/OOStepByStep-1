namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class TeacherTest
    {
        [Fact]
        public void Should_return_teacher_message_when_given_teacher_name_and_age()
        {
            // given
            Person person = new Teacher("Amy", 30);
            // when
            string message = person.Introduce();
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", message);
        }

        [Fact]
        public void Should_return_teacher_message_when_given_teacher_name_and_age_and_class()
        {
            // given
            Person person = new Teacher("Amy", 30, 2);
            // when
            string message = person.Introduce();
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", message);
        }
    }
}
