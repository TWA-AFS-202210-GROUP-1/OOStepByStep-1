namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_get_name_and_age_when_is_a_person_if_given_name_and_age()
        {
            var person = new Person();
            var res = person.Print();
            Assert.Equal("My name is Tom.I am 21 years old.", res);
        }

        [Fact]
        public void Should_get_name_age_and_title_when_is_a_student_if_given_name_age_and_title_as_student()
        {
            var student = new Student();
            var res = student.Print();
            Assert.Equal("My name is Tom.I am 21 years old.I am a student.", res);
        }

        [Fact]
        public void Should_get_name_age_and_title_when_is_a_teacher_if_given_name_age_and_title_as_teacher()
        {
            var teacher = new Teacher();
            var res = teacher.Print();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", res);
        }
    }
}
