namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class IntroduceTest
    {
        [Fact]
        public void Should_return_person_introduction_When_call_introduce_Given_person_name_age()
        {
            //given
            Person person = new Person(name: "Tom", age: 18);
            string expectationIntroduction = "My name is Tom. I am 18 years old.";

            //when
            string personIntroduction = person.Introduce();

            //then
            Assert.Equal(expectationIntroduction, personIntroduction);
        }

        [Fact]
        public void Should_return_student_introduction_When_call_introduce_Given_student_name_age()
        {
            //given
            Student student = new Student(name: "Tom", age: 18);
            string expectationIntroduction = "My name is Tom. I am 18 years old. I am a student.";

            //when
            string studentIntroduction = student.Introduce();

            //then
            Assert.Equal(expectationIntroduction, studentIntroduction);
        }

        [Fact]
        public void Should_return_teacher_introduction_When_class_join_call_introduce_Given_teacher_name_age()
        {
            //given
            Teacher teacher = new Teacher(name: "Amy", age: 30);
            NewClass class2 = new NewClass(classname: "class 2");
            string expectationIntroduction = "My name is Amy. I am 30 years old. I am a teacher of class 2.";

            //when
            string teacherIntroduction = class2.Join(teacher);

            //then
            Assert.Equal(expectationIntroduction, teacherIntroduction);
        }
    }
}
