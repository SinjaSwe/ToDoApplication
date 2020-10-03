using System;
using Xunit;
using ToDoApplication;
using ToDoApplication.Model;

namespace ModelPerson.Tests
{
    public class PersonTests
    {
        [Fact] //Test the constructor works

        public void PersonConstructor()
        
            // Arrange
        {
            string firstname = "Jane";
            string lastname = "Doe";
            int ID = 1;

            //Act
            Person result = new Person(ID, firstname, lastname);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(firstname, result.PersonInformation());
            Assert.Contains(lastname, result.PersonInformation());
        }
                

        [Theory]// TEST THE NULL AND WHITE SPACES ON FIRSTNAME
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        //[InlineData(" test to fail ")]

        public void EmptyCellConstructorPersonFn(string firstname)
        {
            //Arrange
            string lastname = "Doe";
            int ID = 1; 
            Person person = new Person(ID, firstname, lastname);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => person.Firstname = firstname);

        }

        [Theory]// TEST THE NULL AND WHITE SPACES ON LASTNAME
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        //[InlineData(" test to fail ")]
        public void EmptyCellConstructorPersonLn(string lastname)
        {
            //Arrange
            string firstname = "Jane";
            int ID = 1;
            Person person = new Person(ID, firstname, lastname);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => person.Lastname = lastname);
        }

    }
}
