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

        [Fact]
        public void Should_return_teacher_introduction_When_call_introduce_Given_teacher_name_age()
        {
            //given
            Teacher teacher = new Teacher(name: "Amy", age: 30);
            string expectationIntroduction = "My name is Amy. I am 30 years old. I am a teacher.";

            //when
            string studentIntroduction = teacher.Introduce();

            //then
            Assert.Equal(expectationIntroduction, studentIntroduction);
        }
    }
}
