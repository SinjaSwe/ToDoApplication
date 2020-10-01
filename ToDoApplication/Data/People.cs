using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApplication.Model;

namespace ToDoApplication.Data
{
    class People
    {
        /*     
       
        f.Add a method public void Clear()that clears all Person objects from the Person array.
        g.Unit test People class.h.Commit changes.
        */

        //a. Have a private static Person arraydeclared and instantiated as empty and not null(new Person[0]).

        static string[] Person = new string[0];

        //b.Add a method publicint Size()that return the length of the array.

        public static int Size()
        {
            return Person.Length;  
        }

        // c.Add a method public Person[] FindAll()that return the Person array.

        
        public Person[] FindAll()
        {                       
            string[] result = Array.FindAll(Person, element => element.Length >= 0);

            return result; 
        }

        //d.Add a method public Person FindById(int personId)that return the person that has a matching personId as the passed in parameter.

        public Person FindById(int personId)
        {
         return Array.Find(Person, element => element == personId);            
        }

        //e.Add a method that creates a new Person, adds the newly created object in the array and then return the created object.
        //You have to “expand” the Person array.(tip: send in parameters needed to create the Person object and use the PersonSequencer to give a unique personId)

        public static string AddNewPerson(int nextPersonId, string firstname, string lastname)
        {
                        Person newPerson = new Person(nextPersonId, firstname, lastname);

            personArray[] newPersonArray = Arrays.copyOf()
            
            
            //create a new person
            
            person = addNewPerson(Person, firstname, lastname) ;
            return true; 

            //Add new person to array
            personArray = personArray.Concat(new[] { fullname }).ToArray();

            //Or personArray.Add(fullname);


            PrintValues(personArray, '\t');


        }
    }
}
