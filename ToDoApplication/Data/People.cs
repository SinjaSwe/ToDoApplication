using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ToDoApplication.Model;
using ToDoApplication.Data; 

namespace ToDoApplication.Data
{
    public class People
    {
        Person[] arrayOfPersons = new Person[0]; //a. Have a private static Person arraydeclared and instantiated as empty and not null(new Person[0]).

        public int Size() //b.Add a method publicint Size()that return the length of the array.
        {
            int size = arrayOfPersons.Length;
            return size; 
        }        

        public Person[] FindAll() // c.Add a method public Person[] FindAll()that return the Person array.
        {
            return arrayOfPersons;
        }                     

        public Person FindById(int personId) //d.Add a method public Person FindById(int personId)that return the person that has a matching personId as the passed in parameter.
        {         
           for  (int i = 0; i < arrayOfPersons.Length; i++)
            {
                if (arrayOfPersons[i].PersonId == personId)
                {
                    return arrayOfPersons[i];
                }
            }
            return null; 
        }

        public Person AddNewPerson(int personId, string firstname, string lastname) //e.Add a method that creates a new Person, adds the newly created object in the array and then return the created object.
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId(), firstname, lastname);

            Array.Resize(ref arrayOfPersons, arrayOfPersons.Length + 1);

            arrayOfPersons[arrayOfPersons.Length - 1] = newPerson;

            return newPerson;         }
        

        public void Clear() //f.Add a method public void Clear()that clears all Person objects from the Person array.
        {
            Array.Clear(arrayOfPersons, 0, arrayOfPersons.Length);
        }

       

    }
}
