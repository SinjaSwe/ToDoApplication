using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
    public class PersonSequencer
    {
        //In PersonSequencer create a private static int variable called personId.
        private static int personId;

        //Add a static method called nextPersonId that increment and return the next personId value.

        public static int nextPersonId(int personId)
        {
            int nextId;
            nextId = ++personId;
            return nextId;
        }

        //Add a static method called reset() that sets the personId variable to 0.

        public static int reset(int personId)
        {
            personId = 0;
            return personId;
        }
    }


}
