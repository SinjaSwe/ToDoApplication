using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
    public class PersonSequencer
    {        
        private static int personId; //In PersonSequencer create a private static int variable called personId.
        
        public static int NextPersonId() //Add a static method called nextPersonId that increment and return the next personId value.
        {
            int nextId = ++personId;
            return nextId;
        }       

        public static void Reset() //Add a static method called reset() that sets the personId variable to 0.
        {
            personId = 0; 
        }
    }


}
