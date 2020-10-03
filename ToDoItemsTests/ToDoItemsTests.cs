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
        //{//Arrange
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
            string description = "Learn to code";

            PersonSequencer.Reset();

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
        //[Fact]
        //public void TestName()
        //{//Arrange
        //Act
        //Assert}

        [Fact]
        public void FindByDoneStatusTest()
        {
            //
            People people = new People();
            ToDoItems toDo = new ToDoItems();
            PersonSequencer.Reset();
            TodoSequencer.ResetID();

            Person Jane = people.AddNewPerson(1, "Jane", "Doe");

            ToDo item1 = toDo.AddNewToDoNew(1, "Win lotto", false, Jane);
            ToDo item2 = toDo.AddNewToDoNew(1, "Learn to code", true, Jane);

            //Act
            ToDo[] result = toDo.FindByDoneStatus();

            //Assert
            Assert.Contains(item2, result); //Jane has learned to code
            Assert.DoesNotContain(item1, result); //Jane has not yet won the lotto

        }

        [Fact]
        public void FindByAssigneeTest()
        {
            //Arrange
            People people = new People();
            ToDoItems toDo = new ToDoItems();
            PersonSequencer.Reset();
            TodoSequencer.ResetID();

            Person Jane = people.AddNewPerson(1, "Jane", "Doe");
            Person John = people.AddNewPerson(2, "John", "Doe");

            ToDo item1 = toDo.AddNewToDoNew(1, "Win lotto", false, Jane);
            ToDo item2 = toDo.AddNewToDoNew(2, "Learn to code", true, John);

            //Act

            ToDo[] result = toDo.FindByAssignee(1);
            ToDo[] result2 = toDo.FindByAssignee(2);

            //Assert
            Assert.Contains(item1, result);
            Assert.Contains(item2, result2);
        }

        [Fact]
        public void FindByFirstnameTest()
        {
            //Arrange
            People people = new People();
            ToDoItems toDo = new ToDoItems();
            PersonSequencer.Reset();
            TodoSequencer.ResetID();

            Person Jane = people.AddNewPerson(1, "Jane", "Doe");
            Person John = people.AddNewPerson(2, "John", "Doe");

            ToDo item1 = toDo.AddNewToDoNew(1, "Win lotto", false, Jane);
            ToDo item2 = toDo.AddNewToDoNew(2, "Learn to code", false, John);

            //Act

            ToDo[] result = toDo.FindByFirstname(Jane);
            ToDo[] result2 = toDo.FindByFirstname(John);

            //Assert
            Assert.Contains(item1, result);
            Assert.Contains(item2, result2);
        }

        public void FindByLastnameTest()
        {
            //Arrange
            People people = new People();
            ToDoItems toDo = new ToDoItems();
            PersonSequencer.Reset();
            TodoSequencer.ResetID();

            Person Doe = people.AddNewPerson(1, "Jane", "Doe");
            Person Smith = people.AddNewPerson(2, "John", "Smith");

            ToDo item1 = toDo.AddNewToDoNew(1, "Win lotto", false, Doe);
            ToDo item2 = toDo.AddNewToDoNew(2, "Learn to code", false, Smith);

            //Act

            ToDo[] result = toDo.FindByLastname(Doe);
            ToDo[] result2 = toDo.FindByLastname(Smith);

            //Assert
            Assert.Contains(item1, result);
            Assert.Contains(item2, result2);
        }

        public ToDo[] FindUnassignedTodoItems()
        {
            //Arrange
            People people = new People();
            ToDoItems toDo = new ToDoItems();
            PersonSequencer.Reset();
            TodoSequencer.ResetID();

            Person Jane = people.AddNewPerson(1, "Jane", "Doe");
            Person John = people.AddNewPerson(2, "John", "Doe");

            ToDo item1 = toDo.AddNewToDoNew(1, "Win lotto", false, Jane);
            ToDo item2 = toDo.AddNewToDoNew(2, "Learn to code", true, John);
            ToDo itemNotDone1 = toDo.AddNewToDoNew(3, "Yet to be assigned", false); 

            //Act

            ToDo[] result = toDo.FindUnassignedTodo();
            
            //Assert
            Assert.Contains(itemNotDone1, result);
            Assert.DoesNotContain(item1, result);
        }
    }
}