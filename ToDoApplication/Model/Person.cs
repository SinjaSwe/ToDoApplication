using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Model
{
    public class Person
    {
        //RequiredPrivateFields
        readonly int personId;
        string firstname;
        string lastname;

        public int PersonId { get { return personId; } }

        //constructor
        public Person(int personId, string firstname, string lastname)
        {
            this.personId = personId;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))

                {
                    throw new ArgumentException("Lastname is null, empty or consists only of white space.");
                }
                else
                {
                    firstname = value;
                }
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname is null, empty or consists only of white space.");
                }
                else
                {
                    lastname = value;
                }
            }
        }

        public string PersonInformation()
        {
            return $"Person ID: {personId}\n\nFirstname: {firstname}\nLastname: {lastname}\n\n";
        }

        
    }

}