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
            int personId = 0;
            int personIdIncreased = 1;

            //Act
            int newId = PersonSequencer.NextPersonId();

            //Assert 
            Assert.Equal(newId, personIdIncreased);
        }

        [Fact] //Test if it resets to 0

        public void TestResetSequence()
        {
            //Arrange
            
            int personId = 1;
            PersonSequencer.NextPersonId();
            int personIdReset = 0;

            //Act

            PersonSequencer.Reset();
            int resetId = PersonSequencer.NextPersonId();

            //Assert
            Assert.Equal(personIdReset, resetId);

        }

    }
}
