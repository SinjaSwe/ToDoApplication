using System;
using Xunit;
using ToDoApplication.Data;

namespace DataPersonSequencer.Tests
{
    public class PersonSequencerTest
    {
        //[Fact]
        //public void TestName()Model
        //Arrange
        //Act
        //Assert

        [Fact] //Test if increases by 1
        public void TestIncreaseIdSequence()
        {
            //Arrange
            int expected = 1; // first person starts at 1;

            //Act
            PersonSequencer.Reset();
            int actual = PersonSequencer.NextPersonId();

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact] //Test if it resets to 0

        public void TestResetSequence()
        {
            //Arrange                       
            PersonSequencer.NextPersonId();
            int personIdReset = 1;

            //Act

            PersonSequencer.Reset();
            int resetId = PersonSequencer.NextPersonId();

            //Assert
            Assert.Equal(personIdReset, resetId);

        }

    }
}
