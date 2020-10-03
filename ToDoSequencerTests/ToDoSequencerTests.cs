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
            int newTdID = TodoSequencer.NextToDo();

            //Assert
            Assert.Equal(newTdID, nextToDoID);

        }

        [Fact]
        public void TestTdResetSequence()
        {
            //Arrange
            TodoSequencer.NextToDo();
            int toDoTdReset = 1;


            //Act
            TodoSequencer.ResetID(); 
            int resetTdId = TodoSequencer.NextToDo();

            //Assert
            Assert.Equal(resetTdId, toDoTdReset);

        }


}
}
