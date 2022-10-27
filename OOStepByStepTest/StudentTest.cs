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
    }
}
