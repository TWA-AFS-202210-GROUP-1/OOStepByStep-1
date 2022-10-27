namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class IntroduceTest
    {
        [Fact]
        public void Should_return_student_introduction_When_call_introduce_Given_student_name_age()
        {
            //given
            Student student = new Student(name: "Tom", age: 21);
            string expectationIntroduction = "My name is Tom. I am 21 years old.";

            //when
            string studentIntroduction = student.Introduce();

            //then
            Assert.Equal(expectationIntroduction, studentIntroduction);
        }
    }
}
