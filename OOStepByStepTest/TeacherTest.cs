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

        [Fact]
        public void Should_return_teacher_message_when_given_name_and_age_and_class_and_new_student()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30, 2);
            Student student = new Student("Tom", 18, 2);

            // when
            string message = teacher.WelcomeNewStudent(student);
            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. " +
                         "Welcome Tom join class 2.", message);
        }
    }
}
