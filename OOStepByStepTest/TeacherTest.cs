namespace OOStepByStepTest
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
    }
}