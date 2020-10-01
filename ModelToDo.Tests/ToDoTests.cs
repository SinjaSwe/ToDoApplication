using System;
using Xunit;
using ToDoApplication.Model;

namespace ModelToDo.Tests
{
    public class ToDoTests
    {
        [Fact]
        public void ToDoConstructor() // TEST OF CONSTRUCTOR
        {
            //Arrange
            string description = "Fix Car";
            int toDoId = 1;

            //Act
            ToDo result = new ToDo(toDoId, description);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(description, result.ToDoInformation());
            //Assert.Contains(Convert.ToString(toDoId), result.ToDoInformation()); HOW TO TEST THIS
        }

        [Theory]// replace Fact to test with many alternate values that are bad.
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        //[InlineData(" test to fail ")]

        public void EmptyCellDecsription(string description)
        {
            //Arrange
            int toDoId = 1;
            ToDo toDo = new ToDo(toDoId, description);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => toDo.Description = description);
        }
    }
}
