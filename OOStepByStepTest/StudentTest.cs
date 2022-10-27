namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTest
    {
        [Fact]
        public void Should_return_student_information_when_introduce_give_name_and_age()
        {
            //give
            Student student = new Student("Amy", 30);
            //when
            string info = student.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a student.", info);
        }
    }
}
