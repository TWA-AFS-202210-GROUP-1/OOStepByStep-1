namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class TeacherTest
    {
        [Fact]
        public void Should_return_teacher_information_when_introduce_give_name_and_age()
        {
            //give
            Teacher teacher = new Teacher("Amy", 30, "teacher");
            //when
            string info = teacher.Introduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", info);
        }
    }
}
