using System;
using Xunit;
using ToDoApplication.Data;
using ToDoApplication.Model;

namespace ToDoItemsTests
{
    public class ToDoItemsTests
    {

        //[Fact]
        //public void TestName()
        //{Arrange
        //Act
        //Assert}

        [Fact]
        public void ClearToDoTest()
        {
            //Arrange

            ToDoItems toDoItems = new ToDoItems();
            int expected = 0;

            //Act
            toDoItems.ClearToDo();
            int arraySize = toDoItems.Size();

            //Assert
            Assert.Equal(arraySize, expected);
        }
        [Fact]
        public void AddNewItemToArrayTest()
        {
            //Arrange
            ToDoItems toDoItems = new ToDoItems();
            string description = "Learn to code";
            int toDoId = 1;

            //Act            
            toDoItems.ClearToDo();
            TodoSequencer.ResetID();
            ToDo result = toDoItems.AddNewToDo(toDoId, description);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(toDoId.ToString(), result.ToDoInformation());
            Assert.Contains(description, result.ToDoInformation());           
        }

        [Fact]
        public void FindByIDTest() //Test to find if it finds the ID
        {
            //Arrange
            ToDoItems toDoItems = new ToDoItems();
            int toDoId = 1;
            PersonSequencer.Reset();
            string description = "Learn to code"; 

            toDoItems.AddNewToDo(toDoId, description); 

            //Act            
            ToDo result = toDoItems.FindToDoById(toDoId);

            //Assert
            Assert.Contains(toDoId.ToString(), result.ToDoInformation());
            Assert.Contains(description, result.ToDoInformation());
        }

        [Fact]
        public void FindSizeTest()
        {
            //Arrange
            ToDoItems toDoItems = new ToDoItems();
            int size = 1;
            int toDoId = 1;
            PersonSequencer.Reset();
            string toDo = "Learn to code";

            toDoItems.AddNewToDo(toDoId, toDo);

            //Act
            int result = toDoItems.Size();

            //Assert
            Assert.Equal(size, result);
        }
    }

}