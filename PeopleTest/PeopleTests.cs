using System;
using Xunit;
using ToDoApplication.Data;
using ToDoApplication.Model;

namespace PeopleTests
{
    public class PeopleTests
    {

        //[Fact]
        //public void TestName()
        //Arrange
        //Act
        //Assert

        [Fact]
        public void ClearTest()
        {
            //Arrange
            People people = new People();
            int expected = 0;

            //Act
            people.Clear();
            int arraySize = people.Size();

            //Assert
            Assert.Equal(arraySize, expected);

        }

        [Fact]
        public void AddNewPersonToArrayTest()
        {

            //Arrange
            People people = new People();
            string firstname = "Jane";
            string lastname = "Doe";
            int newPersonID = 1;
            int personID = 0;

            //Act            
            people.Clear();
            PersonSequencer.Reset();
            Person result = people.AddNewPerson(newPersonID, firstname, lastname);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(firstname, result.PersonInformation());
            Assert.Contains(lastname, result.PersonInformation());
            Assert.Contains(newPersonID.ToString(), result.PersonInformation());

        }

        [Fact]
        public void FindByIDTest() //Test to find if it finds the ID
        {
            //Arrange
            People people = new People();
            int personId = 1;
            PersonSequencer.Reset();

            people.AddNewPerson(personId, "Donald", "Duck");                     

            //Act
            Person result = people.FindById(personId);

            //Assert
            Assert.Contains("Donald", result.PersonInformation()); 
            Assert.Contains("Duck", result.PersonInformation()); 
            Assert.Contains(personId.ToString(), result.PersonInformation());
        }

        [Fact]
        public void FindSizeTest()
        {
            //Arrange
            People people = new People();
            PersonSequencer.Reset(); 
            int size = 1;
            int personId = 1;

            people.AddNewPerson(personId, "Donald", "Duck");

            //Act
            int result = people.Size();

            //Assert
            Assert.Equal(size, result);
        }

        /*[Fact]
        public void FindAllTest()
        {
            //Arrange
            People people = new People();

            //Act


            //Assert
        */
    }

}

