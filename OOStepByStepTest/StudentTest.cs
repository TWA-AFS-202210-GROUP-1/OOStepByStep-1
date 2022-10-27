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
            Student student = new Student("Tom", 18);
            //when
            string info = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", info);
        }

        [Fact]
        public void Should_return_student_information_when_introduce_give_name_and_age_class()
        {
            //give
            Student student = new Student("Tom", 18, 2);
            //when
            string info = student.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student. I am a student of class 2", info);
        }
    }
}
