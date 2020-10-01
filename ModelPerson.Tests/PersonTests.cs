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

            //Act
            Person result = new Person(firstname, lastname);

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
            Person person = new Person(firstname, lastname);

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
            Person person = new Person(firstname, lastname);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => person.Lastname = lastname);
        }

    }
}
