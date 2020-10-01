using System;
using Xunit;
using ToDoApplication.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ToDoSequencerTests
{
    public class ToDoSequencerTests
    {
        [Fact]
        public void TestIncreaseToDoSequence()
        {
            //Arrange
            int toDoId = 0;
            int nextToDoID = 1;

            //Act
            int newTdID = TodoSequencer.NextToDo(toDoId);

            //Assert
            Assert.Equal(newTdID, nextToDoID);

        }

        [Fact]
        public void TestTdResetSequence()
        {
            //Arrange
            int toDoId = 3;
            int resetId = 0;

            //Act
            int resetTdId = TodoSequencer.ResetID(toDoId);

            //Assert
            Assert.Equal(resetId, resetTdId); 

        }
}
}
