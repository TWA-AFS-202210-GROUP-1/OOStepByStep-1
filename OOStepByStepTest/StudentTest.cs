namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTest
    {
        [Fact]
        public void Should_return_student_message_when_given_student_name_and_age()
        {
            // given
            Person person = new Student("Tom", 18);
            // when
            string message = person.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", message);
        }

        [Fact]
        public void Should_return_student_message_when_given_teacher_name_and_age_and_class()
        {
            // given
            Person person = new Teacher("Tom", 18, 2);
            // when
            string message = person.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a teacher of class 2.", message);
        }
    }
}
