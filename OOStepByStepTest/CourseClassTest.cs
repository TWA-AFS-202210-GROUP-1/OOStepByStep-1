using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class CourseClassTest
    {
        [Fact]
        public void Should_return_true_when_add_teacher_given_teacher_to_class()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            var courseClass = new CourseClass("Class 2");
            //when

            var result = courseClass.AddTeacher(teacher);

            //then
            Assert.True(result);
        }
    }
}
