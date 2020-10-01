using System;
using Xunit;
using ToDoApplication.Data;

namespace DataPersonSequencer.Tests
{
    public class PersonSequencerTest
    {
        //Model
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
            int newId = PersonSequencer.nextPersonId(personId);

            //Assert 
            Assert.Equal(newId, personIdIncreased);
        }

        [Fact] //Test if it resets to 0

        public void TestResetSequence()
        {
            //Arrange
            
            int personId = 3;
            int personIdReset = 0;

            //Act

            int resetId = PersonSequencer.reset(personId);

            //Assert
            Assert.Equal(personIdReset, resetId);

        }

    }
}
