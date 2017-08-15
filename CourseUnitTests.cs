namespace UnitTestExample
{
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [ExcludeFromCodeCoverage]
    [TestClass]
    public class CourseUnitTests
    {
        [TestMethod]
        public void complete_returns_correct_message()
        {
            var course = new Course();

            var mockPerson = new Mock<IPerson>();

            mockPerson.Setup(s => s.CompleteClass()).Returns("test");

            var result = course.Complete(mockPerson.Object);

            Assert.AreEqual(result, "test");
        }
    }
}
