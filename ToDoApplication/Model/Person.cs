using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Model
{
    public class Person
    {
        //RequiredPrivateFields
        int personId;
        string firstname;
        string lastname;

        //constructor
        public Person(string firstname, string lastname)
        {
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
            return $"\n\nFirstname: {firstname}\nLastname: {lastname}\n\n";
        }

        public string Fullname ()
        {
            return $" {firstname} {lastname}"; 
        }
    }

}