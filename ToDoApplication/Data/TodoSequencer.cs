using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
    public class TodoSequencer
    {
        // private static int variable called personId

        private static int toDoID;

        // Add a static method called nextToDoId that increment and return the next personId value

        public static int NextToDo()
        {
            int nextToDoId = ++toDoID;
            return nextToDoId;
        }

        //Return to zero
        public static void ResetID()
        {
            toDoID = 0;
        }
    }
}
